﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzerszamgepKereskedelem.Models;

namespace SzerszamgepKereskedelem.Repositories
{
    class GepRepository
    {
        private List<gepek> gepekLista;
        private szerszamgepContext db;
        private List<string> gyartok;
        private List<string> tipusok;
        public GepRepository()
        {
            gepekLista = new List<gepek>();
            gyartok = new List<string>();
            tipusok = new List<string>();
            db = new szerszamgepContext();
            gepekLista = db.gepek.ToList();
        }
        public gepek getGepById(int gepId)
        {
            db = new szerszamgepContext();
            gepekLista = db.gepek.ToList();
            if (gepekLista.FindIndex(g => g.id == gepId) < 0)
            {
                return null;
            }
            else
            {
                return gepekLista.Find(g => g.id == gepId);
            }
        }
        public List<string> getGyartokLista()
        {
            
            foreach (var item in gepekLista)
            {
                if (item.gyarto != "")
                {
                    gyartok.Add(item.gyarto);
                }          
            }
            gyartok=gyartok.Distinct().OrderBy(gy=>gy).ToList();
            gyartok.Insert(0, "-------Kérem válasszon-------");
            return gyartok;
        }
        public List<string> getTipusokLista()
        {
            
            foreach (var item in gepekLista)
            {
                if (item.tipus != "")
                {
                    tipusok.Add(item.tipus);
                }
            }
            tipusok = tipusok.Distinct().OrderBy(t => t).ToList();
            tipusok.Insert(0, "-------Kérem válasszon-------");
            return tipusok;
        }
    }
}
