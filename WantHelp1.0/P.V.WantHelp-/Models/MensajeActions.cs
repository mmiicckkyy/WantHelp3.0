using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P.V.WantHelp_.Models
{
    public class MensajeActions
    {
        PlataformaVirtualEntities server;
        public MensajeActions()
        {
            server = new PlataformaVirtualEntities();
        }
        public List<mensajes> getMensajes(int msn)
        {
            return server.mensajes.Take(10).Where(a=>a.idSe==msn).OrderByDescending(a => a.id).ToList();
        }
    }
}