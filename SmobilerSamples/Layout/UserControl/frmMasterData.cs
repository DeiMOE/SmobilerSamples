﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerSamples.Layout.UserControl
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmMasterData : Smobiler.Core.Controls.MobileUserControl
    {
        public frmMasterData() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            //this.Form.Close(); 
        }

        private void ImgUser_Press(object sender, EventArgs e)
        {

        }

        private void Img_Press(object sender, EventArgs e)
        {

        }

        private void btnSex_Press(object sender, EventArgs e)
        {

        }

        private void txtLocation_TouchLeave(object sender, EventArgs e)
        {

        }

        private void dpkBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void plAssetsType_Press(object sender, EventArgs e)
        {

        }

        private void plWareHouse_Press(object sender, EventArgs e)
        {

        }

        private void plClient_Press(object sender, EventArgs e)
        {

        }

        private void plSupplier_Press(object sender, EventArgs e)
        {

        }
    }
}