﻿using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace Sims3Dashboard
{
    public partial class FrameworkInfo : Form
    {
        public FrameworkInfo(List<ListViewItem> curPackageList)
        {
            this.packageList = curPackageList;
            InitializeComponent();
        }

        private List<ListViewItem> packageList = new List<ListViewItem>();

        private void FrameworkInfo_Load(object sender, EventArgs e)
        {
            checkLocations();
        }

        private void checkLocations()
        {

            MadScience.Helpers.findInstalledGames();

            for (int i = 0; i < MadScience.Helpers.gamesInstalled.Items.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                MadScience.Helpers.GameInfo gameInfo = MadScience.Helpers.gamesInstalled.Items[i];
                item.Text = gameInfo.gameName;
                if (gameInfo.isInstalled)
                {
                    item.SubItems.Add("Yes");
                    if (MadScience.Helpers.gamesInstalled.globalFramework.hasFramework)
                    {
                        item.SubItems.Add("Common");
                    }
                    else
                    {
                        if (gameInfo.hasFramework)
                        {
                            item.SubItems.Add("Yes");
                        }
                        else
                        {
                            item.SubItems.Add("No");
                        }
                    }
                }
                else
                {
                    item.SubItems.Add("No");
                    item.SubItems.Add("");
                }

                if (gameInfo.version.Major > 0)
                {
                    item.SubItems.Add(gameInfo.version.ToString());
                }
                else
                {
                    item.SubItems.Add("");
                }
                item.SubItems.Add(gameInfo.path);

                listView3.Items.Add(item);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                string path = listView3.SelectedItems[0].SubItems[4].Text;
                MadScience.Helpers.OpenWindow(path);
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                if (listView3.SelectedItems[0].SubItems[1].Text == "Yes")
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
                if (listView3.SelectedItems[0].SubItems[2].Text == "Yes" || listView3.SelectedItems[0].SubItems[2].Text == "Common")
                {
                    linkLabel1.Visible = false;
                }
                else
                {
                    linkLabel1.Visible = true;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.modthesims.info/wiki.php?title=Game_Help:Installing_Sims_3_Package_Files");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Version vrs = new Version(Application.ProductVersion);
            string debugInfo = "Framework Info, generated by Sims 3 Dashboard v" + vrs.ToString(4) + System.Environment.NewLine;
            debugInfo += "---------------------------------------------------------------";
            debugInfo += System.Environment.NewLine;
            debugInfo += "OS: " + System.Environment.OSVersion.ToString() + System.Environment.NewLine;
            debugInfo += "CPUs: " + System.Environment.ProcessorCount.ToString() + System.Environment.NewLine;
            debugInfo += System.Environment.NewLine;

            MadScience.Helpers.findInstalledGames();

            debugInfo += MadScience.Helpers.gamesInstalled.Items.Count.ToString() + " games installed" + System.Environment.NewLine;
            debugInfo += System.Environment.NewLine;

            for (int i = 0; i < MadScience.Helpers.gamesInstalled.Items.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                MadScience.Helpers.GameInfo gameInfo = MadScience.Helpers.gamesInstalled.Items[i];

                debugInfo += "Game: " + gameInfo.gameName + System.Environment.NewLine;
                debugInfo += "Version: " + gameInfo.version + System.Environment.NewLine;
                debugInfo += "Path: " + gameInfo.path + System.Environment.NewLine;
                debugInfo += "Has Framework: " + gameInfo.hasFramework + System.Environment.NewLine;
                debugInfo += "Global Framework: " + gameInfo.useGlobalFramework + System.Environment.NewLine;
                debugInfo += System.Environment.NewLine;

            }

            debugInfo += "Checking for corrupt/broken/borked packages: " + System.Environment.NewLine;

            MadScience.Detective detective = new MadScience.Detective();

            for (int i = 0; i < packageList.Count; i++)
            {
                ListViewItem item = packageList[i];
                if (item.BackColor == detective.pType.ToColor(MadScience.Detective.PackageTypes.emptyPackage)) debugInfo += item.SubItems[2].Text + ": [ " + item.Text + " ] Desc: [ " + item.SubItems[6].Text + " ] Size: [ " + item.SubItems[3].Text + " ]" + System.Environment.NewLine;
                if (item.BackColor == detective.pType.ToColor(MadScience.Detective.PackageTypes.conflictPackage)) debugInfo += "Conflicted: [ " + item.Text + " ] Type: [ " + item.SubItems[2].Text + " ] Desc: [ " + item.SubItems[6].Text + " ] Size: [ " + item.SubItems[3].Text + " ]" + System.Environment.NewLine;
                if (item.BackColor == detective.pType.ToColor(MadScience.Detective.PackageTypes.sims2Package)) debugInfo += item.SubItems[2].Text + ": [ " + item.Text + " ] Desc: [ " + item.SubItems[6].Text + " ] Size: [ " + item.SubItems[3].Text + " ]" + System.Environment.NewLine;
                if (item.SubItems[2].Text.StartsWith("Corrupt")) debugInfo += item.SubItems[2].Text + ": [ " + item.Text + " ] Desc: [ " + item.SubItems[6].Text + " ] Size: [ " + item.SubItems[3].Text + " ]" + System.Environment.NewLine;

            }


            string tmpFile = Path.GetTempFileName();
            StreamWriter tmpStream  = new StreamWriter(tmpFile);
            tmpStream.Write(debugInfo);
            tmpStream.Close();

            Process notepad = new Process();
            notepad.StartInfo.FileName = "notepad.exe";
            notepad.StartInfo.Arguments = tmpFile;
            notepad.Start();


                        
        }

    }
}
