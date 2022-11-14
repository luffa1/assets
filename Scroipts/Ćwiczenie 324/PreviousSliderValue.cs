public class PreviousSliderValue {
    // private PreviousSliderValue() {}

    // private static PreviousSliderValue instance = null;

    public float sliderValue = 0;

    // public static PreviousSliderValue GetInstance() {
    //     if (instance == null) {
    //         instance = new PreviousSliderValue();
    //     }

    //     return instance;
    // }

    public void SetSliderValue(float sliderValue) {
        this.sliderValue = sliderValue;
    }

    public float GetSliderValue() {
        return sliderValue;
    }
}