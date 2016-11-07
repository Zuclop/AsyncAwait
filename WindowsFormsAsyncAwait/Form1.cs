using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace WindowsFormsAsyncAwait
{
    public partial class FileLoggerForm : Form
    {
        private string logFileName = "File Log.txt";
        private static object locker = new object();

        public FileLoggerForm()
        {
            InitializeComponent();
        }

        private async void AddToLogButton_Click(object sender, EventArgs e)
        {
            await LogFile(FilePathTextBox.Text);
        }

        private async Task LogFile(string sourcePath)
        {
            await Task.Run(() =>
            {
                lock (locker)
                {
                    try
                    {
                        byte[] buffer = new byte[1024];
                        int readedBytes;
                        using (FileStream DestinationStream = File.Open(logFileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read),
                            SourceStream = File.Open(sourcePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            DestinationStream.Seek(0, SeekOrigin.End);
                            while (true)
                            {
                                readedBytes = SourceStream.Read(buffer, 0, buffer.Length);
                                if (readedBytes == 0)
                                    break;
                                DestinationStream.Write(buffer, 0, readedBytes);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            });
        }
    }
}
