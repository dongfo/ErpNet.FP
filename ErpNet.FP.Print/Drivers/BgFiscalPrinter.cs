using System.Collections.Generic;
using ErpNet.FP.Print.Core;

namespace ErpNet.FP.Print.Drivers
{
    /// <summary>
    /// Fiscal printer using the Zfp implementation.
    /// </summary>
    /// <seealso cref="ErpNet.FP.IFiscalPrinter" />
    public class BgFiscalPrinter : IFiscalPrinter
    {
        public DeviceInfo DeviceInfo => FiscalPrinterInfo;

        public DeviceInfo FiscalPrinterInfo;

        protected IChannel Channel;  
        protected IDictionary<string, string> Options;  

        public BgFiscalPrinter(IChannel channel, IDictionary<string, string> options = null) {
            Options = options;
            Channel = channel;            
        }

        public virtual bool IsReady()
        {
            throw new System.NotImplementedException();
        }

        public virtual PrintInfo PrintMoneyDeposit(decimal amount)
        {
            throw new System.NotImplementedException();
        }

        public virtual PrintInfo PrintMoneyWithdraw(decimal amount)
        {
            throw new System.NotImplementedException();
        }

        public virtual PrintInfo PrintReceipt(Receipt receipt)
        {
            throw new System.NotImplementedException();
        }

        public virtual PrintInfo PrintReversalReceipt(Receipt reversalReceipt)
        {
            throw new System.NotImplementedException();
        }

        public virtual PrintInfo PrintZeroingReport()
        {
            throw new System.NotImplementedException();
        }

        public virtual void SetupPrinter()
        {
            // Nothing to be configured for now.
        }
    }
}
