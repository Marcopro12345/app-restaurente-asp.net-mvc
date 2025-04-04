using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IMenuAD
    {
        List<PA_recMenu_Result> recMenus();

        PA_recMenuXId_Result recMenusxid(int pId);

        bool insMenus(menu pobjMenu);

        bool modMenus(menu pobjMenu);

        bool delMenus(menu pobjMenu);

    }
}
