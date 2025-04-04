using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IMenuLN
    {
        List<PA_recMenu_Result> recMenusln();

        PA_recMenuXId_Result recMenusXIdln(int pId);

        bool insMenuln(menu pobjMenu);

        bool modMenuln(menu pobjMenu);

        bool delMenuln(menu pobjMenu);
    }
}
