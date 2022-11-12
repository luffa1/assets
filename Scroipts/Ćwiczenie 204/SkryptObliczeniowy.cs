public class SkryptObliczeniowy {
    public float CalculateAmper(float u) {
        float r = 11;

        return u / r;
    }
    public float CalculateVoltage(float i) {
        float r = 11;

        return i * r;
    }
    // Obliczanie wychylenia ramienia 
    public float CalculateSwing(float x)   // to jest tylko przykład zapisu poszukać wzoru 
    {
        float l = 1;
        return x + l;
    }
}