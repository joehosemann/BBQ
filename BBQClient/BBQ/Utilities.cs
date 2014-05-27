using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BBQ
{
    class Utilities
    {
        public DataTable DuplicateRowRemove(DataTable dt)
        {
            Hashtable hTable = new Hashtable();
            ArrayList ArrDupli = new ArrayList();

            foreach (DataRow r in dt.Rows)
            {
                if (hTable.Contains(r))
                    ArrDupli.Add(r);
                else
                    hTable.Add(r, string.Empty);

            }

            foreach (DataRow r in ArrDupli)
                dt.Rows.Remove(r);

            return dt;
        }

        //http://www.codeproject.com/Tips/128709/Ensure-visibility-of-your-windows-when-switching-c
        public static void ensureWindowVisibility(MainWindow pWindow)
        {
            var screens = System.Windows.Forms.Screen.AllScreens;
            var currentWorkArea = System.Windows.SystemParameters.WorkArea;
            var windowRect = new System.Windows.Rect(pWindow.Left, pWindow.Top, pWindow.Width, pWindow.Height);

            if (screens.Count() == 1)
            {
                if (!currentWorkArea.IntersectsWith(windowRect))
                {
                    pWindow.Left = 100;
                    pWindow.Top = 100;
                }
            }
        }
    }
}
