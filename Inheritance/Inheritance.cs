using System;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Meadow.JsonRpc.Types;
using Meadow.JsonRpc.Client;
using Meadow.UnitTestTemplate;
using Meadow.Core.Utils;
using Meadow.Core.EthTypes;
using Meadow.Contract;
using Meadow.CoverageReport.Debugging;


namespace HoshoAudit
{
    [TestClass]
    public class InheritanceTests : ContractTest
    {
        protected Inheritance inherit;

        protected override async Task BeforeEach()
        {
            inherit = await Inheritance.New(RpcClient);
        }

        [TestMethod]
        public async Task inheritTrue()
        {
            var returnedLogEvent = await inherit.returnsTrue().FirstEventLog<Inheritance.Returned>();
            Assert.AreEqual(returnedLogEvent.from, Accounts[0]);
            Assert.AreEqual(returnedLogEvent.returned, true);
        }

        [TestMethod]
        public async Task inheritFromModifiers()
        {
            await inherit.isOwner();
        }
    }
}


