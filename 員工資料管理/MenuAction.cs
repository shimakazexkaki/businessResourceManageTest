using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 員工資料管理
{
    public interface MenuAction
    {
        event EventHandler Refresh_MenuEvent;
        event EventHandler Add_MenuEvent;
        event EventHandler Edit_MenuEvent;
        event EventHandler Delete_MenuEvent;
        event EventHandler Import_MenuEvent;
        event EventHandler Export_MenuEvent;
        bool HasEventRefresh { get; }
        bool HasEventAdd { get; }
        bool HasEventEdit { get; }
        bool HasEventDelete { get; }
        bool HasEventImport { get; }
        bool HasEventExport { get; }
        void ProcessRefresh(object sender, EventArgs e);
        void ProcessAdd(object sender, EventArgs e);
        void ProcessEdit(object sender, EventArgs e);
        void ProcessDelete(object sender, EventArgs e);
        void ProcessImport(object sender, EventArgs e);
        void ProcessExport(object sender, EventArgs e);
    }
}
