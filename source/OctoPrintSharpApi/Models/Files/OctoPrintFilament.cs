﻿using Newtonsoft.Json;

namespace AndreasReitberger.Models
{
    public partial class OctoPrintFilament
    {
        #region Properties
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public double Length { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public double Volume { get; set; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}
