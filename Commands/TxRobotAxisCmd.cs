using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tecnomatix.Engineering;

namespace Commands
{
    public class TxRobotAxisCmd : TxButtonCommand
    {
        public override string Category
        {
            get
            {
                return "Robot";
            }
        }

        public override string Name
        {
            get
            {
                return "KUKA external";
            }
        }
        public override string Bitmap
        {
            get
            {
                return "Plugomatix.bmp";
            }
        }

        public override void Execute(object cmdParams)
        {
            TxRobotAxisForm robotForm = new TxRobotAxisForm();
            robotForm.Show();

        }
    }
}
