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
    public class BranchTests : ContractTest
    {
        protected Branches branch;

        protected override async Task BeforeEach()
        {
            branch = await Branches.New(RpcClient);
        }

        [TestMethod]
        public async Task allBranches()
        {
            await branch.multipleBranches(3, 2, 1);
        }

        [TestMethod]
        public async Task noBranches()
        {
            await branch.multipleBranches(1, 1, 1).ExpectRevertTransaction();
        }

        [TestMethod]
        public async Task oneBranch()
        {
            await branch.multipleBranches(10, 2, 2).ExpectRevertTransaction();
        }

        [TestMethod]
        public async Task twoBranches()
        {
            await branch.multipleBranches(10, 5, 2).ExpectRevertTransaction();
        }

        [TestMethod]
        public async Task threeBranches()
        {
            await branch.multipleBranches(10, 9, 3).ExpectRevertTransaction();
        }
    }
}


