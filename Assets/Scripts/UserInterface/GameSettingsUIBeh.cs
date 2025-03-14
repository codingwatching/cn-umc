using UnityEngine;
using UnityEngine.UI;
public class GameSettingsUIBeh : MonoBehaviour
{
    public static GameSettingsUIBeh instance;
    public Button saveButton;
    public Slider gameFOVSlider;
    public Slider controlSensSlider;
    public Slider gameSoundVolumeSlider;
    public Text gameFOVText;
    public Text controlSensText;
    public Text gameSoundVolumeText;
  void Start(){
    instance=this;
    saveButton=GameObject.Find("savebutton").GetComponent<Button>();
    gameFOVSlider=GameObject.Find("gamefovslider").GetComponent<Slider>();
    controlSensSlider=GameObject.Find("controlsensslider").GetComponent<Slider>();
    gameSoundVolumeSlider=GameObject.Find("gamesoundvolumeslider").GetComponent<Slider>();
    gameFOVText=GameObject.Find("gamefovtext").GetComponent<Text>();
    controlSensText=GameObject.Find("controlsenstext").GetComponent<Text>();
    gameSoundVolumeText=GameObject.Find("gamesoundvolumetext").GetComponent<Text>();
    saveButton.onClick.AddListener(SaveButtonOnClick);
    gameFOVSlider.onValueChanged.AddListener(GameFOVSliderOnValueChanged);
    controlSensSlider.onValueChanged.AddListener(ControlSensSliderOnValueChanged);
    gameSoundVolumeSlider.onValueChanged.AddListener(GameSoundVolumeSliderOnValueChanged);
    gameFOVSlider.value = GlobalGameOptions.inGameFOV;
    gameSoundVolumeSlider.value = GlobalGameOptions.gameVolume;
    controlSensSlider.value = GlobalGameOptions.inGameMouseSensitivity;

  }
  void SaveButtonOnClick(){
    GameSettingsUIBeh.instance.gameObject.SetActive(false);
  }
  void GameFOVSliderOnValueChanged(float f){
      GlobalGameOptions.inGameFOV = gameFOVSlider.value;
      
    gameFOVText.text=gameFOVSlider.value.ToString();
  }
  void ControlSensSliderOnValueChanged(float f)
  {
      GlobalGameOptions.inGameMouseSensitivity = controlSensSlider.value;
    
    controlSensText.text=controlSensSlider.value.ToString();
  }
  void GameSoundVolumeSliderOnValueChanged(float f){
      GlobalGameOptions.gameVolume = gameSoundVolumeSlider.value;
        AudioListener.volume=gameSoundVolumeSlider.value;
    gameSoundVolumeText.text=gameSoundVolumeSlider.value.ToString();
  }
}
