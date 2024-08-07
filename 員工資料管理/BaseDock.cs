using System;
using System.Windows.Forms;

namespace 員工資料管理
{
    public partial class BaseDock : Form, MenuAction
    {
        public event EventHandler Refresh_MenuEvent;
        public event EventHandler Add_MenuEvent;
        public event EventHandler Edit_MenuEvent;
        public event EventHandler Delete_MenuEvent;
        public event EventHandler Import_MenuEvent;
        public event EventHandler Export_MenuEvent;

        public bool HasEventRefresh => Refresh_MenuEvent != null;
        public bool HasEventAdd => Add_MenuEvent != null;
        public bool HasEventEdit => Edit_MenuEvent != null;
        public bool HasEventDelete => Delete_MenuEvent != null;
        public bool HasEventImport => Import_MenuEvent != null;
        public bool HasEventExport => Export_MenuEvent != null;

        public void ProcessRefresh(object sender, EventArgs e)
        {
            Refresh_MenuEvent?.Invoke(sender, e);
        }

        public void ProcessAdd(object sender, EventArgs e)
        {
            Add_MenuEvent?.Invoke(sender, e);
        }

        public void ProcessEdit(object sender, EventArgs e)
        {
            Edit_MenuEvent?.Invoke(sender, e);
        }

        public void ProcessDelete(object sender, EventArgs e)
        {
            Delete_MenuEvent?.Invoke(sender, e);
        }

        public void ProcessImport(object sender, EventArgs e)
        {
            Import_MenuEvent?.Invoke(sender, e);
        }

        public void ProcessExport(object sender, EventArgs e)
        {
            Export_MenuEvent?.Invoke(sender, e);
        }
    }
}
