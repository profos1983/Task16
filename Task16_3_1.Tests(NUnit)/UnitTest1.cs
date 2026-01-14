using Moq;
using Task16_3_1;
namespace Task16_3_1.Tests_NUnit_
{
    public class Tests
    {

        [Test]
        public void FindAll_Must_Return_Null()
        {
//Выполните тестирование функции FindAll при помощи moq - объекта.Используйте 
//следующие три имени пользователей для добавления в moq-коллекцию: Антон, Иван, Алексей.
//При написании теста используйте фреймворк NUnit. Для проверки наличия элемента в коллекции 
//используйте метод That класса Assert и метод Any синтаксиса Linq.
            var mockUserRepository = new Mock<IUserRepository> ();
            mockUserRepository.Setup (x => x.
            Assert.Pass();
        }
    }
}
