﻿using MusicApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApplication
{
    public partial class ArtistForm : BaseView
    {
        public ArtistForm()
        {
            InitializeComponent();
        }

        public override void Open<T>(T item)
        {
            var artist = item as Artist;

        }
    }
}
