﻿using Newtonsoft.Json;

namespace AndreasReitberger.Models
{
    public class OctoPrintActivePrintInfoChangedEventArgs : OctoPrintEventArgs
    {
        #region Properties
        public OctoPrintJobInfo NewActivePrintInfo { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
