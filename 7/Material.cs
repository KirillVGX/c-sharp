public class Material {
    private string name;
    private double kg;
    private double price;
    private string code;

    public string GetName() {
        return name;
    }

    public void SetName(string value) {
        name = value;
    }

    public double GetKg() {
        return kg;
    }

    public void SetKg(double value) {
        kg = value;
    }

    public double GetPrice() {
        return price;
    }

    public void SetPrice(double value) {
        price = value;
    }

    public string GetCode() {
        return code;
    }

    public void SetCode(string value) {
        code = value;
    }

    public static double AveragePrice(Material[] materials) {
        double sum = 0;
        foreach (var m in materials) {
            sum += m.GetPrice();
        }

        return sum / materials.Length;
    }
}