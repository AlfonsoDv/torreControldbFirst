﻿using System;
using System.Collections.Generic;

namespace torreControldbFristDAL.Modelo;

public partial class TdcCatLineasDistribucion
{
    public string MdUuid { get; set; } = null!;

    public DateTime MdDate { get; set; }

    public int Id { get; set; }

    public string CodLinea { get; set; } = null!;

    public string CodProvincia { get; set; } = null!;

    public string CodMunicipio { get; set; } = null!;

    public string CodBarrio { get; set; } = null!;

    public virtual ICollection<TdcTchEstadoPedido> TdcTchEstadoPedidos { get; } = new List<TdcTchEstadoPedido>();
}
