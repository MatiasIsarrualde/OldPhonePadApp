using NUnit.Framework;
namespace OldPhonePadTests
{
    [TestFixture]
    public class TestPhonePad
    {
        [Test]
        public void Test_BasicFunctionality()
        {
            Assert.That( Program.OldPhonePad("33#"), Is.EqualTo("E"), "Test Failed: Expected E");
        }

        [Test]
        public void Test_BackspaceFunctionality()
        {
            Assert.That(Program.OldPhonePad("227*#"), Is.EqualTo("B"), "Test Failed: Expected B after backspace");
        }

        [Test]
        public void Test_MultipleCharacters()
        {
            Assert.That( Program.OldPhonePad("4433555 555666#"), Is.EqualTo("HELLO"), "Test Failed: Expected HELLO");
        }

        [Test]
        public void Test_RepeatedNumbers()
        {
            Assert.That(Program.OldPhonePad("222#"), Is.EqualTo("C"), "Test Failed: Expected C");
            Assert.That(Program.OldPhonePad("7777#"), Is.EqualTo("S"), "Test Failed: Expected S");
        }

        [Test]
        public void Test_WithSpaces()
        {
            Assert.That(Program.OldPhonePad("2 22#"), Is.EqualTo("AB"), "Test Failed: Expected AB");
        }

        [Test]
        public void Test_BackspaceInMiddle()
        {
            Assert.That(Program.OldPhonePad("44*3#"), Is.EqualTo("D"), "Test Failed: Expected D after backspacing");
        }

        [Test]
        public void Test_EmptyInput()
        {
            Assert.Throws<ArgumentException>(() => Program.OldPhonePad("#"), "Test Failed: Empty Output");
        }

        [Test]
        public void Test_InvalidCharacter()
        {
            Assert.Throws<ArgumentException>(() => Program.OldPhonePad("12A#"), "Test Failed: The only acceptable characters are numbers, spaces or asterisks.");
        }
    }

}