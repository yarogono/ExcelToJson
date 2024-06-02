using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance;
    private static Managers Instance { get { Init(); return s_instance; } }

    #region
    private DataManager _data = new DataManager();
    private PoolManager _pool = new PoolManager();
    private ResourceManager _resource = new ResourceManager();
    private SceneManagerEx _scene = new SceneManagerEx();
    private SoundManager _sound = new SoundManager();
    private UIManager _ui = new UIManager();


    public static DataManager Data { get { return Instance?._data; } }
    public static PoolManager Pool { get { return Instance?._pool; } }
    public static ResourceManager Resource {  get { return Instance?._resource; } }
    public static SceneManagerEx Scene { get { return Instance?._scene; } }
    public static SoundManager Sound { get { return Instance?._sound; } }
    public static UIManager UI { get { return Instance?._ui; } }
    #endregion

    private static void Init()
    {
        if (s_instance == null)
        {
            GameObject gameObject = GameObject.FindGameObjectWithTag("@Managers");
            
            if (gameObject == null)
            {
                gameObject = new GameObject { name = "@Managers" };
                gameObject.AddComponent<Managers>();
            }

            DontDestroyOnLoad(gameObject);

            // �ʱ�ȭ
            s_instance = gameObject.GetComponent<Managers>();
        }
    }
}
