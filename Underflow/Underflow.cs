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
    public class UnderflowTest : ContractTest
    {
        protected Underflow underflow;

        protected override async Task BeforeEach()
        {
            underflow = await Underflow.New(RpcClient);

            // Peform contract deployments and other test setup.
        }

        [TestMethod]
        public async Task Uint8()
        {
            var result = await underflow.uint8Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, 255);
        }

        [TestMethod]
        public async Task Uint16()
        {
            var result = await underflow.uint16Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, 65535);
        }

        [TestMethod]
        public async Task Uint24()
        {
            var result = await underflow.uint24Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt32)16777215);
        }

        [TestMethod]
        public async Task Uint32()
        {
            var result = await underflow.uint32Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, 4294967295);
        }

        [TestMethod]
        public async Task Uint40()
        {
            var result = await underflow.uint40Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt64)1099511627775);
        }

        [TestMethod]
        public async Task Uint48()
        {
            var result = await underflow.uint48Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt64)281474976710655);
        }

        [TestMethod]
        public async Task Uint56()
        {
            var result = await underflow.uint56Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt64)72057594037927935);
        }

        [TestMethod]
        public async Task Uint64()
        {
            var result = await underflow.uint64Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, 18446744073709551615);
        }

        [TestMethod]
        public async Task Uint72()
        {
            var result = await underflow.uint72Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("4722366482869645213695"));
        }

        [TestMethod]
        public async Task Uint80()
        {
            var result = await underflow.uint80Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("1208925819614629174706175"));
        }

        [TestMethod]
        public async Task Uint88()
        {
            var result = await underflow.uint88Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("309485009821345068724781055"));
        }

        [TestMethod]
        public async Task Uint96()
        {
            var result = await underflow.uint96Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("79228162514264337593543950335"));
        }

        [TestMethod]
        public async Task Uint104()
        {
            var result = await underflow.uint104Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("20282409603651670423947251286015"));
        }

        [TestMethod]
        public async Task Uint112()
        {
            var result = await underflow.uint112Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("5192296858534827628530496329220095"));
        }

        [TestMethod]
        public async Task Uint120()
        {
            var result = await underflow.uint120Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("1329227995784915872903807060280344575"));
        }

        [TestMethod]
        public async Task Uint128()
        {
            var result = await underflow.uint128Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("340282366920938463463374607431768211455"));
        }

        [TestMethod]
        public async Task Uint136()
        {
            var result = await underflow.uint136Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("87112285931760246646623899502532662132735"));
        }

        [TestMethod]
        public async Task Uint144()
        {
            var result = await underflow.uint144Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("22300745198530623141535718272648361505980415"));
        }

        [TestMethod]
        public async Task Uint152()
        {
            var result = await underflow.uint152Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("5708990770823839524233143877797980545530986495"));
        }

        [TestMethod]
        public async Task Uint160()
        {
            var result = await underflow.uint160Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("1461501637330902918203684832716283019655932542975"));
        }

        [TestMethod]
        public async Task Uint168()
        {
            var result = await underflow.uint168Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("374144419156711147060143317175368453031918731001855"));
        }

        [TestMethod]
        public async Task Uint176()
        {
            var result = await underflow.uint176Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("95780971304118053647396689196894323976171195136475135"));
        }

        [TestMethod]
        public async Task Uint184()
        {
            var result = await underflow.uint184Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("24519928653854221733733552434404946937899825954937634815"));
        }

        [TestMethod]
        public async Task Uint192()
        {
            var result = await underflow.uint192Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("6277101735386680763835789423207666416102355444464034512895"));
        }

        [TestMethod]
        public async Task Uint200()
        {
            var result = await underflow.uint200Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("1606938044258990275541962092341162602522202993782792835301375"));
        }

        [TestMethod]
        public async Task Uint208()
        {
            var result = await underflow.uint208Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("411376139330301510538742295639337626245683966408394965837152255"));
        }

        [TestMethod]
        public async Task Uint216()
        {
            var result = await underflow.uint216Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("105312291668557186697918027683670432318895095400549111254310977535"));
        }

        [TestMethod]
        public async Task Uint224()
        {
            var result = await underflow.uint224Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("26959946667150639794667015087019630673637144422540572481103610249215"));
        }

        [TestMethod]
        public async Task Uint232()
        {
            var result = await underflow.uint232Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("6901746346790563787434755862277025452451108972170386555162524223799295"));
        }

        [TestMethod]
        public async Task Uint240()
        {
            var result = await underflow.uint240Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("1766847064778384329583297500742918515827483896875618958121606201292619775"));
        }

        [TestMethod]
        public async Task Uint248()
        {
            var result = await underflow.uint248Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("452312848583266388373324160190187140051835877600158453279131187530910662655"));
        }

        [TestMethod]
        public async Task Uint256()
        {
            var result = await underflow.uint256Underflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639935"));
        }

        [TestMethod]
        public async Task Uint()
        {
            var result = await underflow.uintUnderflow().CallAndTransact();
            Assert.AreEqual(result.Result, (UInt256)BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639935"));
        }
    }
}