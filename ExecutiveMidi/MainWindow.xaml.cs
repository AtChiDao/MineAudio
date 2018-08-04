﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using Newtonsoft.Json;
using Audio2Minecraft;

namespace ExecutiveMidi
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static TimeLine preTimeLine = new TimeLine(); //预览时间序列
        public static string Midipath = "", oldMidi = ""; //Midi路径
        class Emidiproj //.EmidiProj
        {
            public string Midipath = "";
            public Uri rMidipath;
            public ObservableCollection<Humberger.MidiMarker> TrackMarkerList;
            public ObservableCollection<Humberger.MidiMarker> InstrumentMarkerList;
        }
        public static ExportSetting export = new ExportSetting() { Width = 16 };
        public static bool export_cancel = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MetroWindow_Initialized(object sender, EventArgs e)
        {
            save.IsEnabled = false;
            load.IsEnabled = false;
        }

        private void MidiSelect(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Midi|*.mid";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == true && fileDialog.FileName != null && fileDialog.FileName != "")
            {
                MidiPath.Text = fileDialog.FileName;
                load.IsEnabled = true;
                SetFileShow();
                cancel0.Visibility = Visibility.Visible;
            }
        }
        private void MidiCancel(object sender, MouseButtonEventArgs e)
        {
            MidiPath.Text = "";
            SetFileShow();
            if (MidiPath.Text == "")
            {
                load.IsEnabled = false;
                save.IsEnabled = false;
            }
            cancel0.Visibility = Visibility.Hidden;
            MidiSetting.TracksView.ItemsSource = null;
            MidiSetting.IsEnabled = false;
        }

        private void Load(object sender, MouseButtonEventArgs e)
        {
            if (MidiPath.Text != "" && new FileInfo(MidiPath.Text).Exists)
            {
                var m = MidiPath.Text;
                //Waiting...
                var w = new SubWindow.Waiting(); w.Owner = this;
                BackgroundWorker waiting = new BackgroundWorker();
                waiting.DoWork += (ee, ea) => { };
                waiting.RunWorkerCompleted += (ee, ea) =>
                {
                    Dispatcher.BeginInvoke(new Action(() =>
                    {
                        w.ShowDialog();
                    }));
                };
                waiting.RunWorkerAsync();
                //Work
                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.DoWork += (o, ea) =>
                {
                    if (oldMidi == m) preTimeLine = UpdateMidiInspector(new AudioStreamMidi().Serialize(m, new TimeLine()), preTimeLine);
                    else preTimeLine = new AudioStreamMidi().Serialize(m, new TimeLine());
                };
                worker.RunWorkerCompleted += (o, ea) =>
                {
                    w.Close();
                    Midipath = MidiPath.Text;
                    MidiSetting.IsEnabled = true;
                    MidiSetting.ReadListView(preTimeLine);
                    MidiSetting.TracksView.ItemsSource = MidiSetting.TrackMarkerList; //Track
                    MidiSetting.Plat.IsEnabled = true;
                    MidiSetting.ItemChanged();
                    save.IsEnabled = true;
                    oldMidi = MidiPath.Text;
                };
                worker.RunWorkerAsync();
            }
        }
        private void Save(object sender, MouseButtonEventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "A2M Extended Content(*.amextension)|*.amextend|ExecutiveMidi Project(*.emidiproj)|*.emidiproj|Universal Schematic(*.schematic)|*.schematic|WorldEdit Schematic(*.schematic)|*.schematic";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == true && fileDialog.FileName != null && fileDialog.FileName != "")
            {
                if (fileDialog.FilterIndex == 2) //Emidiproj
                {
                    var f = new Emidiproj()
                    {
                        Midipath = Midipath,
                        rMidipath = (Midipath != "") ? new Uri(fileDialog.FileName.Replace(" ", "*20")).MakeRelativeUri(new Uri(Midipath.Replace(" ", "*20"))) : null,
                        InstrumentMarkerList = MidiSetting.InstrumentMarkerList,
                        TrackMarkerList = MidiSetting.TrackMarkerList
                    };
                    File.WriteAllText(fileDialog.FileName, Compress(JsonConvert.SerializeObject(f))); //加密压缩并输出
                }
                else
                {
                    var commandLine = new CommandLine();
                    //Waiting...
                    var w = new SubWindow.Waiting(); w.Owner = this;
                    BackgroundWorker waiting = new BackgroundWorker();
                    waiting.DoWork += (ee, ea) => { };
                    waiting.RunWorkerCompleted += (ee, ea) =>
                    {
                        Dispatcher.BeginInvoke(new Action(() =>
                        {
                            w.ShowDialog();
                        }));
                    };
                    waiting.RunWorkerAsync();
                    //Work
                    BackgroundWorker worker = new BackgroundWorker();
                    worker.WorkerReportsProgress = true;
                    worker.DoWork += (o, ea) =>
                    {
                        for (var i = 0; i < preTimeLine.TickNodes.Count; i++)
                        {
                            commandLine.Keyframe.Add(new Command());
                        }
                        for (var i = 0; i < preTimeLine.TickNodes.Count; i++)
                        {
                            foreach (var t in preTimeLine.TickNodes[i].MidiTracks.Keys)
                            {
                                var track = preTimeLine.TickNodes[i].MidiTracks[t];
                                foreach (var _i in track.Keys)
                                {
                                    var instrument = track[_i];
                                    var cmd = "";
                                    var start = true;
                                    var track_cmd = MidiSetting.TrackMarkerList.First(k => k.Name == t);
                                    var instr_cmd = MidiSetting.InstrumentMarkerList.First(k => k.Name == _i);
                                    if (track_cmd != null && track_cmd.Command != "")
                                    {
                                        cmd = track_cmd.Command;
                                        start = track_cmd.Location == Humberger.MidiMarker.ExecuteLocation.Start;
                                    }
                                    if (instr_cmd != null && instr_cmd.Command != "")
                                    {
                                        cmd = instr_cmd.Command;
                                        start = instr_cmd.Location == Humberger.MidiMarker.ExecuteLocation.Start;
                                    }
                                    if (cmd != "")
                                    {
                                        foreach (var node in instrument)
                                        {
                                            var cmds = cmd.Split(Environment.NewLine.ToCharArray());
                                            var k = start ? i : i + node.Param["MinecraftTickDuration"].Value;
                                            foreach (var c in cmds)
                                            {
                                                commandLine.Keyframe[k].Commands.Add(
                                                    MathCmd(
                                                        InheritExpression.Expression(
                                                            cmd,
                                                            node.Param["Pitch"].Value,
                                                            node.Param["MinecraftTickDuration"].Value,
                                                            node.Param["Velocity"].Value,
                                                            node.Param["BarIndex"].Value,
                                                            node.Param["BeatDuration"].Value,
                                                            node.Param["Channel"].Value
                                                            )
                                                    )
                                                );
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    };
                    worker.RunWorkerCompleted += (o, ea) =>
                    {
                        if (fileDialog.FilterIndex == 1) //A2Mextension
                        {
                            File.WriteAllText(fileDialog.FileName, Compress(JsonConvert.SerializeObject(commandLine))); //加密压缩并输出
                            w.Close();
                        }
                        else if (fileDialog.FilterIndex == 3 || fileDialog.FilterIndex == 4) //Schematic
                        {
                            var _w = new SubWindow.Export(); _w.Owner = this;
                            _w.序列宽度.Text = export.Width.ToString();
                            _w.保持区块加载.IsChecked = export.AlwaysLoadEntities;
                            _w.延伸方向.SelectedIndex = export.Direction;
                            _w.ShowDialog();
                            if (!export_cancel)
                            {
                                new Schematic().ExportSchematic(commandLine, export, fileDialog.FileName);
                                w.Close();
                            }
                            else
                            {
                                w.Close();
                                export_cancel = false;
                            }
                        }
                    };
                    worker.RunWorkerAsync();
                }
            }
        }
        private void LoadFile(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "ExecutiveMidi Project(*.emidiproj)|*.emidiproj";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == true && fileDialog.FileName != null && fileDialog.FileName != "")
            {
                var o = JsonConvert.DeserializeObject<Emidiproj>(Decompress(File.ReadAllText(fileDialog.FileName)));
                //relative or absolute or cancel
                var msg = MessageBox.Show("是否使用相对路径导入？", "使用相对路径导入", MessageBoxButton.YesNoCancel); if (msg == MessageBoxResult.Cancel) return;
                if (msg == MessageBoxResult.Yes)
                {
                    o.Midipath = (o.rMidipath != null) ? new Uri(new Uri(fileDialog.FileName.Replace(" ", "*20")), o.rMidipath).LocalPath.Replace("*20", " ") : "";
                }
                if (o.Midipath != "" && new FileInfo(o.Midipath).Exists) //MidiPath
                {
                    Midipath = o.Midipath;
                    MidiPath.Text = o.Midipath;
                    MidiSetting.IsEnabled = true;
                    MidiSetting.ItemChanged();
                    cancel0.Visibility = Visibility.Visible;
                    var m = o.Midipath;
                    //Waiting...
                    var w = new SubWindow.Waiting(); w.Owner = this;
                    BackgroundWorker waiting = new BackgroundWorker();
                    waiting.DoWork += (ee, ea) => { };
                    waiting.RunWorkerCompleted += (ee, ea) =>
                    {
                        Dispatcher.BeginInvoke(new Action(() =>
                        {
                            w.ShowDialog();
                        }));
                    };
                    waiting.RunWorkerAsync();
                    //Work
                    BackgroundWorker worker = new BackgroundWorker();
                    worker.WorkerReportsProgress = true;
                    worker.DoWork += (ou, ea) =>
                    {
                        if (oldMidi == m) preTimeLine = UpdateMidiInspector(new AudioStreamMidi().Serialize(m, new TimeLine()), preTimeLine);
                        else preTimeLine = new AudioStreamMidi().Serialize(m, new TimeLine());
                    };
                    worker.RunWorkerCompleted += (ou, ea) =>
                    {
                        MidiSetting.ReadListView(preTimeLine);
                        MidiSetting.UpdateListView(o.TrackMarkerList, o.InstrumentMarkerList);
                        w.Close();
                        MidiSetting.IsEnabled = true;
                        MidiSetting.Plat.IsEnabled = true;
                        MidiSetting.TracksView.ItemsSource = MidiSetting.TrackMarkerList;
                        MidiSetting.ItemChanged();
                        save.IsEnabled = true;
                        oldMidi = MidiPath.Text;
                    };
                    worker.RunWorkerAsync();
                }
                else
                {
                    MidiSetting.IsEnabled = false;
                    cancel0.Visibility = Visibility.Hidden;
                }
            }
        }
        private void SetFileShow()
        {
            var midiName = (File.Exists(MidiPath.Text)) ? " Midi: \"" + new FileInfo(MidiPath.Text).Name + "\"" : "";
        }
        private TimeLine UpdateMidiInspector(TimeLine newTimeline, TimeLine baseTimeline)
        {
            Task task = Task.Run(() =>
            {
                foreach (var i in newTimeline.InstrumentList)
                {
                    foreach (var _i in baseTimeline.InstrumentList)
                    {
                        if (i.Name == _i.Name)
                        {
                            i.EnableScore = _i.EnableScore;
                            i.EnablePlaysound = _i.EnablePlaysound;
                            i.BarIndex = _i.BarIndex;
                            i.BeatDuration = _i.BeatDuration;
                            i.Channel = _i.Channel;
                            i.DeltaTickDuration = _i.DeltaTickDuration;
                            i.DeltaTickStart = _i.DeltaTickStart;
                            i.Velocity = _i.Velocity;
                            i.Pitch = _i.Pitch;
                            i.MinecraftTickDuration = _i.MinecraftTickDuration;
                            i.MinecraftTickStart = _i.MinecraftTickStart;
                            i.PlaysoundSetting.StopSound = _i.PlaysoundSetting.StopSound;
                            i.PlaysoundSetting.ExecuteCood[0] = _i.PlaysoundSetting.ExecuteCood[0];
                            i.PlaysoundSetting.ExecuteCood[1] = _i.PlaysoundSetting.ExecuteCood[1];
                            i.PlaysoundSetting.ExecuteCood[2] = _i.PlaysoundSetting.ExecuteCood[2];
                            i.PlaysoundSetting.ExecuteTarget = _i.PlaysoundSetting.ExecuteTarget;
                            i.PlaysoundSetting.PlayTarget = _i.PlaysoundSetting.PlayTarget;
                            i.PlaysoundSetting.PlaySource = _i.PlaysoundSetting.PlaySource;
                            i.PlaysoundSetting.InheritExpression = _i.PlaysoundSetting.InheritExpression;
                            i.PlaysoundSetting.ExtraDelay = _i.PlaysoundSetting.ExtraDelay;
                            i.PlaysoundSetting.SoundName = _i.PlaysoundSetting.SoundName;
                            i.PlaysoundSetting.PercVolume = _i.PlaysoundSetting.PercVolume;
                        }
                    }
                }
                foreach (var t in newTimeline.TrackList)
                {
                    foreach (var i in t.Instruments)
                    {
                        foreach (var _t in baseTimeline.TrackList)
                        {
                            if (t.Name == _t.Name)
                            {
                                foreach (var _i in _t.Instruments)
                                {
                                    if (i.Name == _i.Name)
                                    {
                                        i.EnableScore = _i.EnableScore;
                                        i.EnablePlaysound = _i.EnablePlaysound;
                                        i.BarIndex = _i.BarIndex;
                                        i.BeatDuration = _i.BeatDuration;
                                        i.Channel = _i.Channel;
                                        i.DeltaTickDuration = _i.DeltaTickDuration;
                                        i.DeltaTickStart = _i.DeltaTickStart;
                                        i.Velocity = _i.Velocity;
                                        i.Pitch = _i.Pitch;
                                        i.MinecraftTickDuration = _i.MinecraftTickDuration;
                                        i.MinecraftTickStart = _i.MinecraftTickStart;
                                        i.PlaysoundSetting.StopSound = _i.PlaysoundSetting.StopSound;
                                        i.PlaysoundSetting.ExecuteCood[0] = _i.PlaysoundSetting.ExecuteCood[0];
                                        i.PlaysoundSetting.ExecuteCood[1] = _i.PlaysoundSetting.ExecuteCood[1];
                                        i.PlaysoundSetting.ExecuteCood[2] = _i.PlaysoundSetting.ExecuteCood[2];
                                        i.PlaysoundSetting.ExecuteTarget = _i.PlaysoundSetting.ExecuteTarget;
                                        i.PlaysoundSetting.PlayTarget = _i.PlaysoundSetting.PlayTarget;
                                        i.PlaysoundSetting.PlaySource = _i.PlaysoundSetting.PlaySource;
                                        i.PlaysoundSetting.InheritExpression = _i.PlaysoundSetting.InheritExpression;
                                        i.PlaysoundSetting.ExtraDelay = _i.PlaysoundSetting.ExtraDelay;
                                        i.PlaysoundSetting.SoundName = _i.PlaysoundSetting.SoundName;
                                        i.PlaysoundSetting.PercVolume = _i.PlaysoundSetting.PercVolume;
                                    }
                                }
                            }
                        }
                    }
                }
                baseTimeline = newTimeline;
                baseTimeline.TickNodes = new List<TickNode>(); //Delect TickNodes
            });
            task.Wait();
            return baseTimeline;
        }

        private string MathCmd(string cmd)
        {
            var error = false;
            //%pi
            cmd = cmd.Replace("%pi", Math.PI.ToString());
            //cos
            var cosL = new Regex(@"(?i)(?<=%cos\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in cosL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Cos(result);
                cmd = cmd.Replace("%cos(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //sin
            var sinL = new Regex(@"(?i)(?<=%sin\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in sinL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Sin(result);
                cmd = cmd.Replace("%sin(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //tan
            var tanL = new Regex(@"(?i)(?<=%tan\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in tanL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Tan(result);
                cmd = cmd.Replace("%tan(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //cosa
            var cosaL = new Regex(@"(?i)(?<=%cosa\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in cosaL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Cos(result * Math.PI / 180);
                cmd = cmd.Replace("%cosa(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //sina
            var sinaL = new Regex(@"(?i)(?<=%sina\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in sinaL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Sin(result * Math.PI / 180);
                cmd = cmd.Replace("%sina(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //tana
            var tanaL = new Regex(@"(?i)(?<=%tana\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in tanaL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Tan(result * Math.PI / 180);
                cmd = cmd.Replace("%tana(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //cosh
            var coshL = new Regex(@"(?i)(?<=%cosh\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in coshL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Cosh(result);
                cmd = cmd.Replace("%cosh(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //sinh
            var sinhL = new Regex(@"(?i)(?<=%sinh\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in sinhL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Sinh(result);
                cmd = cmd.Replace("%sinh(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //tanh
            var tanhL = new Regex(@"(?i)(?<=%tanh\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in tanhL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Tanh(result);
                cmd = cmd.Replace("%tanh(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //abs
            var absL = new Regex(@"(?i)(?<=%abs\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in absL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Abs(result);
                cmd = cmd.Replace("%abs(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //round
            var roundL = new Regex(@"(?i)(?<=%round\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in roundL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Round(result);
                cmd = cmd.Replace("%round(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //sqrt
            var sqrtL = new Regex(@"(?i)(?<=%sqrt\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in sqrtL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Sqrt(result);
                cmd = cmd.Replace("%sqrt(" + _c.Value + ")", result.ToString("0.0000"));
            }
            //normal
            var nL = new Regex(@"(?i)(?<=%\()((?<Open>\()|(?<-Open>\))|[^()]+)*(?(Open)(?!))(?=\))").Matches(cmd);
            foreach (var m in nL)
            {
                var _c = m as Match;
                double result = 0;
                error = TryMathExpression(_c.Value, out result);
                result = Math.Sqrt(result);
                cmd = cmd.Replace("%(" + _c.Value + ")", result.ToString("0.0000"));
            }
            return cmd;
        }
        private bool TryMathExpression(string expression, out double result)
        {
            object r = new DataTable().Compute(expression, "");
            result = Convert.ToDouble(r);
            return true;
        }
        #region Compress
        public static string Compress(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            MemoryStream ms = new MemoryStream();
            using (GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true))
            {
                zip.Write(buffer, 0, buffer.Length);
            }

            ms.Position = 0;
            MemoryStream outStream = new MemoryStream();

            byte[] compressed = new byte[ms.Length];
            ms.Read(compressed, 0, compressed.Length);

            byte[] gzBuffer = new byte[compressed.Length + 4];
            System.Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
            System.Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
            return Convert.ToBase64String(gzBuffer);
        }
        public static string Decompress(string compressedText)
        {
            byte[] gzBuffer = Convert.FromBase64String(compressedText);
            using (MemoryStream ms = new MemoryStream())
            {
                int msgLength = BitConverter.ToInt32(gzBuffer, 0);
                ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

                byte[] buffer = new byte[msgLength];

                ms.Position = 0;
                using (GZipStream zip = new GZipStream(ms, CompressionMode.Decompress))
                {
                    zip.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }
        #endregion
    }
}