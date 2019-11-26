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
    public partial class BaseView : UserControl
    {
        public MainForm Frame
        {
            get
            {
                return _mainForm;
            }
            set
            {
                _mainForm = value;
                Parent = value;
            }
        }
        public virtual void Open<T>(T item)
        {
            
        }

        private MainForm _mainForm;

        public BaseView()
        {
            InitializeComponent();
        }
    }
}
