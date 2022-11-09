public class SkryptObliczeniowy {
    public float CalculateAmper(float u) {
        float r = 13;

        return u / r;
    }
    public float CalculateVoltage(float i) {
        float r = 13;

        return i * r;
    }
}