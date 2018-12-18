using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shell32;

namespace ModifyFileNameWithEXIF
{
    public partial class Form1 : Form
    {
        
        //Update the ProgressBar and ProgressLabel UI
        private delegate void ProgressUICallback(int d_ProgressValue, int d_TotalFiles, ProgressBar d_ProgressBar, Label d_Label);
        private void ProgressUIUpdate(int d_ProgressValue, int d_TotalFiles, ProgressBar d_ProgressBar, Label d_Label)
        {
            if(this.InvokeRequired)
            {
                ProgressUICallback t_ProgressBarUICallback = new ProgressUICallback(ProgressUIUpdate);
                this.Invoke(t_ProgressBarUICallback, d_ProgressValue, d_TotalFiles, d_ProgressBar, d_Label);
            }
            else
            {
                d_ProgressBar.Maximum = d_TotalFiles;
                d_ProgressBar.Minimum = 0;
                d_ProgressBar.Value = d_ProgressValue;
                d_Label.Text = d_ProgressValue.ToString() + '/' + d_TotalFiles.ToString();
            }
        }
        private delegate void ListViewUICallback(ListViewItem d_ListViewItem, ListView d_ListView);
        private void ListViewUIUpdate(ListViewItem d_ListViewItem, ListView d_ListView)
        {
            if (this.InvokeRequired)
            {
                ListViewUICallback t_ProgressBarUICallback = new ListViewUICallback(ListViewUIUpdate);
                this.Invoke(t_ProgressBarUICallback, d_ListViewItem, d_ListView);
            }
            else
            {
                d_ListView.Items.Add(d_ListViewItem);
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            InitialListView(ref ListView_Find, new string[] { "Index", "Path", "Name", "LastAccessTime", "LastAccessTimeUtc", "LastWriteTime", "LastWriteTimeUtc", "PictureTime" });
            InitialListView(ref ListView_Modify, new string[] { "Index", "Original Path", "Original Name", "Modify Path", "Modify Name" });
        }
        string m_TimeFormat = "yyyy-MM-dd-HH-mm-ss";
        enum E_LISTVIEW_FIND
        {
            INDEX,
            PATH,
            NAME,
            LASTACCESSTIME,
            LASTACCESSTIMEUTC,
            LASTWRITETIME,
            LASTWRITETIMEUTC,
            PCITURETIME
        }
        enum E_LISTVIEW_MODIFY
        {
            INDEX,
            ORIGINALPATH,
            ORIGINALNAME,
            MODIFYPATH,
            MODIFYNAME
        }
        private Dictionary<string, DateTime> GetFileInfo(string f_FileName)
        {
            FileInfo t_FileInfo = new FileInfo(f_FileName);
            Dictionary<string, DateTime> t_Dicionary = new Dictionary<string, DateTime>();
            t_Dicionary.Add("LastAccessTime", t_FileInfo.LastAccessTime);
            t_Dicionary.Add("LastAccessTimeUtc", t_FileInfo.LastAccessTimeUtc);
            t_Dicionary.Add("LastWriteTime", t_FileInfo.LastWriteTime);
            t_Dicionary.Add("LastWriteTimeUtc", t_FileInfo.LastWriteTimeUtc);
            return t_Dicionary;
        }
        private string GetEXIFPicDate(string t_FileName)
        {
            Image t_Image = Image.FromFile(t_FileName);
            Encoding t_ASCII = Encoding.ASCII;
            string t_PicDate = string.Empty;
            foreach (System.Drawing.Imaging.PropertyItem t_PropertyItem in t_Image.PropertyItems)
            {
                //獲取拍攝日期時間
                if (t_PropertyItem.Id == 0x9003) // 0x0132 最後更新時間
                {
                    t_PicDate = t_ASCII.GetString(t_PropertyItem.Value);
                    if (t_PicDate.Length != 0)
                    {
                        //拍攝日期
                        t_PicDate = t_PicDate.TrimEnd('\0');
                        t_PicDate = t_PicDate.Replace(" ", "-");
                        t_PicDate = t_PicDate.Replace(":", "-");
                    }
                }
            }
            t_Image.Dispose();
            return t_PicDate;
        }
       
        private void InitialListView(ref ListView f_ListView, string[] f_Titles)
        {
            foreach (string t_Title in f_Titles)
            {
                f_ListView.Columns.Add(t_Title, t_Title, 100);
            }
        }
        private void ShowListView(List<string> f_Files)
        {
            for(int i = 0; i< f_Files.Count; i ++)
            {
                ListViewItem t_ListViewItem = new ListViewItem(i.ToString());
                t_ListViewItem.SubItems.Add(System.IO.Path.GetDirectoryName(f_Files[i]));
                t_ListViewItem.SubItems.Add(System.IO.Path.GetFileName(f_Files[i]));
                Dictionary<string, DateTime> t_FileInfo = GetFileInfo(f_Files[i]);
                t_ListViewItem.SubItems.Add(t_FileInfo["LastAccessTime"].ToString(m_TimeFormat));
                t_ListViewItem.SubItems.Add(t_FileInfo["LastAccessTimeUtc"].ToString(m_TimeFormat));
                t_ListViewItem.SubItems.Add(t_FileInfo["LastWriteTime"].ToString(m_TimeFormat));
                t_ListViewItem.SubItems.Add(t_FileInfo["LastWriteTimeUtc"].ToString(m_TimeFormat));
                string t_FilePicDate = GetEXIFPicDate(f_Files[i]);
                t_ListViewItem.SubItems.Add(t_FilePicDate);

                ListViewUIUpdate(t_ListViewItem, ListView_Find);
                ProgressUIUpdate(i + 1, f_Files.Count, progressBar1, label11);
            }
        }
        private void Button_Browser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog t_FolderBrowserDialog = new FolderBrowserDialog();
            if (t_FolderBrowserDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            TextBox_FolderPath.Text = t_FolderBrowserDialog.SelectedPath;
        }

        private void FindFileList()
        {
            List<string> t_Files = new List<string>();
            foreach (string t_string in TextBox_Filter.Text.Split('+'))
            {
                t_Files.AddRange(System.IO.Directory.GetFiles(TextBox_FolderPath.Text, t_string, SearchOption.AllDirectories));
            }
            ShowListView(t_Files);
        }
        
        private void Button_Find_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(TextBox_FolderPath.Text) == false)
            {
                return;
            }
            ListView_Modify.Items.Clear();
            
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(FindFileList));
            thread.Start();
        }
        private Dictionary<string, int> GetTimeFromString(string f_TimeString)
        {
            Dictionary<string, int> DateTimeStringToInt = new Dictionary<string, int>();
            string[] t_TimeString = f_TimeString.Split('-');
            try
            {
                DateTimeStringToInt.Add("Year", int.Parse(t_TimeString[0]));
                DateTimeStringToInt.Add("Month", int.Parse(t_TimeString[1]));
                DateTimeStringToInt.Add("Day", int.Parse(t_TimeString[2]));
                DateTimeStringToInt.Add("Hour", int.Parse(t_TimeString[3]));
                DateTimeStringToInt.Add("Minute", int.Parse(t_TimeString[4]));
                DateTimeStringToInt.Add("Second", int.Parse(t_TimeString[5]));
            }
            catch (Exception Ex)
            {
                DateTimeStringToInt.Add("Year", 1991);
                DateTimeStringToInt.Add("Month", 03);
                DateTimeStringToInt.Add("Day", 09);
                DateTimeStringToInt.Add("Hour", 05);
                DateTimeStringToInt.Add("Minute", 11);
                DateTimeStringToInt.Add("Second", 08);
            }
            return DateTimeStringToInt;
        }
        private void ListView_Find_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem t_SelectItem in ListView_Find.SelectedItems)
            {
                if (t_SelectItem.Selected == true)
                {
                    TextBox_DirectoryPath.Text = t_SelectItem.SubItems[1].Text;
                    TextBox_FullFileName.Text = System.IO.Path.GetFileNameWithoutExtension(t_SelectItem.SubItems[2].Text);
                    TextBox_FileExtension.Text = System.IO.Path.GetExtension(t_SelectItem.SubItems[2].Text);
                    Dictionary<string, int> t_TimeInt;
                    t_TimeInt = GetTimeFromString(t_SelectItem.SubItems[7].Text);
                    DateTimePicker_PictureDate.Value = new DateTime(t_TimeInt["Year"], t_TimeInt["Month"], t_TimeInt["Day"], t_TimeInt["Hour"], t_TimeInt["Minute"], t_TimeInt["Second"]);

                    t_TimeInt = GetTimeFromString(t_SelectItem.SubItems[3].Text);
                    DateTimePicker_LastAccessTime.Value = new DateTime(t_TimeInt["Year"], t_TimeInt["Month"], t_TimeInt["Day"], t_TimeInt["Hour"], t_TimeInt["Minute"], t_TimeInt["Second"]);
                    t_TimeInt = GetTimeFromString(t_SelectItem.SubItems[4].Text);
                    DateTimePicker_LastAccessTimeUtc.Value = new DateTime(t_TimeInt["Year"], t_TimeInt["Month"], t_TimeInt["Day"], t_TimeInt["Hour"], t_TimeInt["Minute"], t_TimeInt["Second"]);
                    t_TimeInt = GetTimeFromString(t_SelectItem.SubItems[5].Text);
                    DateTimePicker_LastWriteTime.Value = new DateTime(t_TimeInt["Year"], t_TimeInt["Month"], t_TimeInt["Day"], t_TimeInt["Hour"], t_TimeInt["Minute"], t_TimeInt["Second"]);
                    t_TimeInt = GetTimeFromString(t_SelectItem.SubItems[6].Text);
                    DateTimePicker_LastWriteTimeUtc.Value = new DateTime(t_TimeInt["Year"], t_TimeInt["Month"], t_TimeInt["Day"], t_TimeInt["Hour"], t_TimeInt["Minute"], t_TimeInt["Second"]);

                }
            }
        }

        private void Button_Modify_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t_ListViewItem in ListView_Find.SelectedItems)
            {
                if(t_ListViewItem.Selected == true)
                {
                    bool IsChange = false;
                    if (string.Compare(TextBox_DirectoryPath.Text, t_ListViewItem.SubItems[1].Text, true) != 0)
                    {
                        IsChange = true;
                    }
                    string t_FileName = TextBox_FullFileName.Text + TextBox_FileExtension.Text;
                    if (string.Compare(t_ListViewItem.SubItems[2].Text, t_FileName, true) != 0)
                    {
                        IsChange = true;
                    }
                    if (IsChange == true)
                    {
                        ListViewItem t_ModifyListViewItem = new ListViewItem(t_ListViewItem.Index.ToString());
                        t_ModifyListViewItem.SubItems.Add(t_ListViewItem.SubItems[1].Text);
                        t_ModifyListViewItem.SubItems.Add(t_ListViewItem.SubItems[2].Text);
                        t_ModifyListViewItem.SubItems.Add(TextBox_DirectoryPath.Text);
                        t_ModifyListViewItem.SubItems.Add(TextBox_FullFileName.Text + TextBox_FileExtension.Text);
                        ListView_Modify.Items.Add(t_ModifyListViewItem);
                        t_ListViewItem.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void DoFileMove()
        {
            int i = 0;
            foreach (ListViewItem t_ListViewItem in t_Temp)
            {
                i++;
                string t_OriginalPath = System.IO.Path.Combine(t_ListViewItem.SubItems[1].Text, t_ListViewItem.SubItems[2].Text);
                string t_ModifyPath = System.IO.Path.Combine(t_ListViewItem.SubItems[3].Text, t_ListViewItem.SubItems[4].Text);
                int t_RepeatTime = 0;
                if (string.Compare(t_OriginalPath, t_ModifyPath, true) != 0)
                {
                    while (true)
                    {
                        try
                        {
                            System.IO.File.Move(t_OriginalPath, t_ModifyPath);
                            break;
                        }
                        catch (Exception Ex)
                        {
                            string t_Directory = System.IO.Path.GetDirectoryName(t_ModifyPath);
                            string t_FileName = System.IO.Path.GetFileNameWithoutExtension(t_ModifyPath) + "_1" + (++t_RepeatTime).ToString();
                            string t_Extension = System.IO.Path.GetExtension(t_ModifyPath);
                            t_ModifyPath = System.IO.Path.Combine(t_Directory, t_FileName + t_Extension);
                        }
                    }
                }
                ProgressUIUpdate(i, ListView_Modify.Items.Count, progressBar2, label12);
            }
        }
        ListViewItem[] t_Temp;
        private void Button_DoFileMove_Click(object sender, EventArgs e)
        {
            t_Temp = new ListViewItem[ListView_Modify.Items.Count];
            ListView_Modify.Items.CopyTo(t_Temp, 0);

            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(DoFileMove));
            thread.Start();
        }

        private void Button_ModifyBatch_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem t_ListViewItem in ListView_Find.Items)
            {
                if(string.IsNullOrEmpty(t_ListViewItem.SubItems[(int)E_LISTVIEW_FIND.PCITURETIME].Text) == false)
                {
                    string t_FileExtension = System.IO.Path.GetExtension(t_ListViewItem.SubItems[(int)E_LISTVIEW_FIND.NAME].Text);
                    ListViewItem t_ModifyListViewItem = new ListViewItem(t_ListViewItem.Index.ToString());
                    t_ModifyListViewItem.SubItems.Add(t_ListViewItem.SubItems[1].Text);
                    t_ModifyListViewItem.SubItems.Add(t_ListViewItem.SubItems[(int)E_LISTVIEW_FIND.NAME].Text);
                    t_ModifyListViewItem.SubItems.Add(t_ListViewItem.SubItems[(int)E_LISTVIEW_FIND.PATH].Text);
                    t_ModifyListViewItem.SubItems.Add(t_ListViewItem.SubItems[(int)E_LISTVIEW_FIND.PCITURETIME].Text + t_FileExtension);
                    ListView_Modify.Items.Add(t_ModifyListViewItem);
                    t_ListViewItem.ForeColor = Color.Red;
                }
            }
        }

        private void Button_DeleteModifyItems_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem t_ListViewItem in ListView_Modify.Items)
            {
                t_ListViewItem.Remove();
            }
        }

        private void Button_DeleteFindItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem t_ListViewItem in ListView_Find.Items)
            {
                t_ListViewItem.Remove();
            }
        }
    }

}
