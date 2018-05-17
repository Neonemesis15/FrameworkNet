using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lucky.Entity.Common.Application
{     
    /// <summary>
    /// Clase:              ECadenas
    /// Creada Por:         Ing. Carlos Alberto Hernández Rincón
    /// Fecha de Creación:  13/06/2009
    /// Requerimientos No:  
    /// Descripcion:        Define los atributos y propiedades de los mismos para la Clase Cadenas
    /// Modificación:       25/06/2009 idmarketchain se cambia por int , este ahora es un identity Ing. 
    ///                     Mauricio Ortiz                      
    /// </summary>


    public class ECadenas
    {
        public ECadenas()
        {
            //Aqui se define el constructor por defecto        
        }

        //Aqui se definen los atributos
        private int lidmarketChain;
        private string lMarketChainname;
        private bool lMarketChainStatus;
        private string lMarketChainCreateBy;
        private DateTime lMarketChainDateBy;
        private string lMarketChainModiBy;
        private DateTime lMarketChainDateModiBy;


        //Defino las propiedades de los atributos
        public int idmarketChain
        {
            get { return this.lidmarketChain; }
            set { this.lidmarketChain = value; }
        }
        public string MarketChainname
        {
            get { return this.lMarketChainname; }
            set { this.lMarketChainname = value; }
        }
        public bool MarketChainStatus
        {
            get { return this.lMarketChainStatus; }
            set { this.lMarketChainStatus = value; }
        }
        public string MarketChainCreateBy
        {
            get { return this.lMarketChainCreateBy; }
            set { this.lMarketChainCreateBy = value; }
        }
        public DateTime MarketChainDateBy
        {
            get { return this.lMarketChainDateBy; }
            set { this.lMarketChainDateBy = value; }
        }
        public string MarketChainModiBy
        {
            get { return this.lMarketChainModiBy; }
            set { this.lMarketChainModiBy = value; }
        }
        public DateTime MarketChainDateModiBy
        {
            get { return this.lMarketChainDateModiBy; }
            set { this.lMarketChainDateModiBy = value; }
        }
    }
}
       
