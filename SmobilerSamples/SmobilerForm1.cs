using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerSamples
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup grp1 = new ListMenuViewGroup();
            grp1.Items.Add(new ListMenuViewItem("logon", "ListView�����ˢ��", "", "") { Tag = "demoListViewRefresh" });
            grp1.Items.Add(new ListMenuViewItem("logon", "����ѡ��", "", "") { Tag = "userFilter" });
            grp1.Items.Add(new ListMenuViewItem("logon", "�ײ���������Dialog", "", "") { Tag = "userFooterDialog" });
            grp1.Items.Add(new ListMenuViewItem("logon", "�������������", "", "") { Tag = "userDialogPassword" });
            grp1.Items.Add(new ListMenuViewItem("logon", "ShowDialig���ȡ����", "", "") { Tag = "demogetdata" });
            grp1.Items.Add(new ListMenuViewItem("logon", "WebView���ظ�����Դ", "", "") { Tag = "demoWebView" });
            this.listMenuView1.Groups.Add(grp1);
        }

        userFilter filter;
        DialogOptions filterOptions;

        SmobilerSamples.ShowDialog.userFooterDialog footerDialog;
        DialogOptions footerDialogOptions;

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            switch (e.Item.Tag.ToString())
            {
                case "demoListViewRefresh":
                    this.Show(new demoListViewRefresh());
                    break;
                case "userFilter":
                    //Dialog��ʾ���Զ���ؼ�������ظ�ʹ�ã�����Ҫÿһ�ζ�ʵ�����������Ҫʵ�������ǵð�ԭ���ĸ�Destroy
                    if (filter == null)
                    {
                        //�����ڲ�ʹ����Flex���֣���Ҫ���ⲿ�����߶�
                        filter = new userFilter();
                        filter.Height = 400;
                        filter.BackColor = System.Drawing.Color.White;
                        //���һ����������֧�ֵ���հ״��ر�
                        filterOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                    }
                    this.ShowDialog(filter, filterOptions);
                    break;
                case "userFooterDialog":
                    //Dialog��ʾ���Զ���ؼ�������ظ�ʹ�ã�����Ҫÿһ�ζ�ʵ�����������Ҫʵ�������ǵð�ԭ���ĸ�Destroy
                    if (footerDialog == null)
                    {
                        //�����ڲ��ؼ������˸߶ȣ�����userFooterDialog�������ø߶ȣ����Զ��Ŵ�
                        footerDialog = new SmobilerSamples.ShowDialog.userFooterDialog();
                        //���һ����������֧�ֵ���հ״��ر�
                        footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                    }
                    this.ShowDialog(footerDialog, footerDialogOptions);
                    break;
                case "userDialogPassword":
                    if (footerDialogOptions == null)
                        footerDialogOptions = new DialogOptions(LayoutJustifyAlign.FlexEnd, System.Drawing.Color.FromArgb(128, 128, 128, 128), Padding.Empty, true);
                    ShowDialog.userDialogPassword dialogPassowrd = new ShowDialog.userDialogPassword();
                    dialogPassowrd.DialogPassword += (pass) => { MessageBox.Show(pass); };
                    this.ShowDialog(dialogPassowrd, footerDialogOptions);
                    break;
                case "demogetdata":
                    demogetdata dm = new demogetdata();
                    dm.Selected += (obj, args) => { Toast(args.Text); };
                    this.ShowDialog(dm);
                    break;
                case "demoWebView":
                    this.Show(new demoWebView());
                    break;
            }

        }
    }
}