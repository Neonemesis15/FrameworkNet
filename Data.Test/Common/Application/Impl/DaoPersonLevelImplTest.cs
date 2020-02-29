using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucky.Entity.Common.Application;
using Lucky.Data.Common.Application;
using Lucky.Data.Common.Application.Impl;

namespace Data.Test.Common.Application.Impl
{
    [TestFixture]
    public class DaoPersonLevelImplTest
    {
        
        public void test() {
            (1).Should().Be(1);
        }

        [Test]
        public void personLevelInsOk() {
            
            int result = -1;
            I_DaoPersonLevel oDaoPersonLevel = new DaoPersonLevelImpl();
            result = oDaoPersonLevel.personLevelIns(Util.Tools.ePersonLevelOk());
            oDaoPersonLevel.personLevelDel("TEST");
            result.Should().Be(1);
        }
        [Test]
        public void personLevelDelOk() {

            int result = -1;
            I_DaoPersonLevel oDaoPersonLevel = new DaoPersonLevelImpl();
            oDaoPersonLevel.personLevelIns(Util.Tools.ePersonLevelOk());
            result = oDaoPersonLevel.personLevelDel("TEST");
            result.Should().Be(1);
        }

        [Test]
        public void personLevelDuplicateYes() {
            int result = -1;
            I_DaoPersonLevel oDaoPersonLevel = new DaoPersonLevelImpl();
            result = oDaoPersonLevel.personLevelIsDuplicate(Util.Tools.ePersonLevelDuplicate());
            result.Should().BeGreaterThan(0);
        }

        [Test]
        public void personLevelDuplicateNo() {
            int result = -1;
            I_DaoPersonLevel oDaoPersonLevel = new DaoPersonLevelImpl();
            result = oDaoPersonLevel.personLevelIsDuplicate(Util.Tools.ePersonLevelNotDuplicate());
            result.Should().Be(0);
        }
    }
}
