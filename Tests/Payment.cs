using NUnit.Framework;

namespace Amica.vNext.Models.Tests
{
	[TestFixture]
	public class Payment : BaseTestClass
	{
		[Test]
		public void WritablePropertyAssertions ()
		{
			WritablePropertyAssertions (typeof(Payment));
		}
		[Test]
		public void DefaultValues ()
		{
            var p = new Models.Payment();
            Assert.That(p.FirstPaymentOption, Is.EqualTo(PaymentOptions.FirstPaymentOptions[1]));
            Assert.That(p.FirstPaymentDate, Is.EqualTo(PaymentOptions.FirstPaymentDates[1]));
            Assert.That(p.FirstPaymentDateAdditionalDays, Is.EqualTo(30));
            Assert.That(p.Installments, Is.EqualTo(1));
            Assert.That(p.InstallmentsEveryNumberOfDays, Is.EqualTo(30));
            Assert.That(p.ForceEndOfMonth, Is.True);
		}

	}
}