using System;

class User {
    private string name;
    private string surname;
    private string phone;
    private long creditCard;

    public string GetName() {
        return name;
    }

    public void SetName(string value) {
        name = value;
    }

    public string GetSurname() {
        return surname;
    }

    public void SetSurname(string value) {
        surname = value;
    }

    public string GetPhone() {
        return phone;
    }

    public void SetPhone(string value) {
        phone = value;
    }

    public long GetCreditCard() {
        return creditCard;
    }

    public void SetCreditCard(long value) {
        creditCard = value;
    }

    public bool IsCreditCardInRange(long min, long max) {
        return creditCard >= min && creditCard <= max;
    }
}