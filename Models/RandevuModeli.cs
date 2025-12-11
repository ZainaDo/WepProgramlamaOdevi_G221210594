using System;
using System.Collections.Generic;

namespace WepProjesi.Models
{
    public class RandevuModeli
    {
        public int SecilenAntrenorId { get; set; }

        public DateTime RandevuZamani { get; set; }

        public List<AntrenorModeli> Antrenorler { get; set; } = new();
    }
}
