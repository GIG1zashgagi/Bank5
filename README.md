Практическая работа №6: 
Создание автоматизированных Unit-тестов

Описание проекта

Данный проект демонстрирует создание автоматизированных модульных тестов (unit-тестов) для класса BankAccount с использованием средств автоматизации Microsoft Visual Studio методом "белого ящика".

Проект состоит из двух частей:

Bank - консольное приложение с классом BankAccount, реализующим операции банковского счета

BankTests - проект модульного тестирования, содержащий тесты для проверки функциональности класса BankAccount

Класс BankAccount
Описание
Класс BankAccount представляет банковский счет с возможностью внесения (Credit) и снятия (Debit) денежных средств.

Документирование кода
Класс и его методы документированы с использованием XML-комментариев:

/// <summary>
/// Класс, представляющий банковский счет с операциями дебета и кредита
/// </summary>
public class BankAccount
{
    /// <summary>
    /// Снимает указанную сумму со счета
    /// </summary>
    /// <param name="amount">Сумма для снятия</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Выбрасывается, если сумма снятия превышает баланс или меньше нуля
    /// </exception>
    public void Debit(double amount)
    /// <summary>
    /// Вносит указанную сумму на счет
    /// </summary>
    /// <param name="amount">Сумма для внесения</param>
    /// <exception cref="System.ArgumentOutOfRangeException">
    /// Выбрасывается, если сумма внесения меньше нуля
    /// </exception>
    public void Credit(double amount)
}

Модульное тестирование
Тестовый проект
Проект BankTests создан с использованием фреймворка MSTest. Тестовый класс BankAccountTests содержит методы для проверки функциональности класса BankAccount.

Требования к тестовому классу
Атрибут [TestClass] - обязателен для класса с тестами

Атрибут [TestMethod] - обязателен для каждого метода теста

[TestMethod]
public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
{
    // Arrange
    double beginningBalance = 11.99;
    double debitAmount = 20.0;
    BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);
    // Act
    try
    {
        account.Debit(debitAmount);
    }
    catch (System.ArgumentOutOfRangeException e)
    {
        // Assert
        StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
        return;
    }
    Assert.Fail("The expected exception was not thrown.");
}

Скриншоты
*Работа консольного приложения*

![](https://github.com/GIG1zashgagi/Bank5/blob/2396c195d6e9a6556cb1142559d81cdc96ef8379/2.png)

*Рисунок 2 - Результаты выполнения всех тестов в обозревателе тестов Visual Studio*

![](https://github.com/GIG1zashgagi/Bank5/blob/2396c195d6e9a6556cb1142559d81cdc96ef8379/1.png)

Выводы
В ходе выполнения практической работы было проведено тестирование программного модуля BankAccount с использованием средств автоматизации Microsoft Visual Studio методом "белого ящика".

