using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public partial class RootElement
    {
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var meeting in Meetings)
            {
                RootElementPasture pas = null;
                foreach (var pasture in Pastures)
                {
                    foreach (var name in pasture.Name)
                    {
                        if (name == meeting.Location)
                            pas = pasture;
                    }
                }

                result.Append($"Meeting in pasture of area {pas.Area}\n");
                result.Append($"Participants: \n");
                foreach (var participant in meeting.Participant)
                    foreach (var item in Items)
                    {
                        if (item is RootElementCentaur)
                        {
                            var pc = item as RootElementCentaur;
                            if (pc.id == participant)
                                result.Append("\t" + pc.Name + "\n");
                        }
                        else
                        {
                            var pm = item as RootElementMinotaur;
                            if (pm.id == participant)
                                result.Append("\t" + pm.Name + "\n");
                        }
                    }
                result.Append("\n");
            }

            return result.ToString();
        }
    }
}
