using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // �̱��� ����
    public static GameManager gm;

    private void Awake()
    {
        if(gm == null)
        {
            gm = this;
        }
    }

    // ���� ���� ���
    public enum GameState
    {
        Ready,
        Run,
        Pause,
        GameOver
    }

    // ������ ���� ���� ����
    public GameState gState;

    public GameObject guide;

    public GameObject PanelMenu;

    // ���� ���� UI ������Ʈ ����
    public GameObject gameLabel;

    //public GameObject buttons;

    bool option = false;
    bool panel = true;

    // ���� ���� UI �ؽ�Ʈ ������Ʈ ����
    Text gameText;


    // PlayerMove Ŭ���� ����
    PlayerMove player;

    // �ɼ� ȭ�� UI ������Ʈ ����
    public GameObject gameOption;

    // Start is called before the first frame update
    void Start()
    {
        PanelMenu.SetActive(false);

        //showHideMenu();
        //Cursor.visible = false;

        //buttons.SetActive(option);

        //guide.SetActive(false);

        // �ʱ� ���� ���´� �غ� ���·� �����Ѵ�.
        gState = GameState.Ready;

        //// ���� ���� UI ������Ʈ���� Text ������Ʈ�� �����´�.
        //gameText = gameLabel.GetComponent<Text>();

        //// ���� �ؽ�Ʈ�� ������ 'Ready...'�� �Ѵ�.
        //gameText.text = "Ready...";

        //// ���� �ؽ�Ʈ�� ������ ��Ȳ������ �Ѵ�.
        //gameText.color = new Color32(255, 185, 0, 255);

        // ���� �غ� -> ���� �� ���·� ��ȯ�ϱ�
        StartCoroutine(ReadyToStart());

        //// �÷��̾� ������Ʈ�� ã�� �� �÷��̾��� PlayerMove ������Ʈ �޾ƿ���
        //player = GameObject.Find("Player").GetComponent<PlayerMove>();
        
    }

    IEnumerator ReadyToStart()
    {
        yield return new WaitForSeconds(0.5f);

        PanelMenu.SetActive(true);

        showHideMenu();
        //guide.SetActive(true);
        // 2�ʰ� ����Ѵ�.

        yield return new WaitForSeconds(1f);

        Time.timeScale = 0f;

        //StartCoroutine(AStart());

        //// ���� �ؽ�Ʈ�� ������ 'Go!'�� �Ѵ�.
        //gameText.text = "Go!";

        //// 0.5�ʰ� ����Ѵ�.
        //yield return new WaitForSeconds(0.5f);

        //// ���� �ؽ�Ʈ�� ��Ȱ���Ѵ�.
        //gameLabel.SetActive(false);

        // ���¸� '���� ��' ���·� �����Ѵ�.

    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.visible = false;

        //// ����, �÷��̾��� hp�� 0 ���϶��...
        //if (player.hp <= 0)
        //{
        //    Cursor.visible = true;

        //    // �÷��̾��� �ִϸ��̼��� �����.
        //    player.GetComponentInChildren<Animator>().SetFloat("MoveMotion", 0f);

        //    // ���� �ؽ�Ʈ�� Ȱ��ȭ�Ѵ�.
        //    gameLabel.SetActive(true);

        //    // ���� �ؽ�Ʈ�� ������ 'Game Over'�� �Ѵ�.
        //    gameText.text = "Game Over";

        //    // ���� �ؽ�Ʈ�� ������ ���������� �Ѵ�.
        //    gameText.color = new Color32(255, 0, 0, 255);

        //    // ���� �ؽ�Ʈ�� �ڽ� ������Ʈ�� Ʈ������ ������Ʈ�� �����´�.
        //    Transform buttons = gameText.transform.GetChild(0);

        //    // ��ư ������Ʈ�� Ȱ��ȭ�Ѵ�.
        //    buttons.gameObject.SetActive(true);

        //    // ���¸� '���� ����' ���·� �����Ѵ�.
        //    gState = GameState.GameOver;
        //}
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!option)
                OpenOptionWindow();
            else
                CloseOptionWindow();

        }
    }

    // �ɼ� ȭ�� �ѱ�
    public void OpenOptionWindow()
    {
        option = true;
        // �ɼ� â�� Ȱ��ȭ�Ѵ�.
        gameOption.gameObject.SetActive(true);
        // ���� �ӵ��� 0������� ��ȯ�Ѵ�.
        Time.timeScale = 0f;
        // ���� ���¸� �Ͻ� ���� ���·� �����Ѵ�.
        gState = GameState.Pause;
        
    }

    // ����ϱ� �ɼ�
    public void CloseOptionWindow()
    {
        option = false;
        // �ɼ� â�� ��Ȱ��ȭ�Ѵ�.
        gameOption.gameObject.SetActive(false);
        // ���� �ӵ��� 1������� ��ȯ�Ѵ�.
        Time.timeScale = 1f;
        // ���� ���¸� ���� �� ���·� �����Ѵ�.
        gState = GameState.Run;
        
    }

    // �ٽ��ϱ� �ɼ�
    public void RestartGame()
    {
        // ���� �ӵ��� 1������� ��ȯ�Ѵ�.
        Time.timeScale = 1f;
        // ���� �� ��ȣ�� �ٽ� �ε��Ѵ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // ���� ���� �ɼ�
    public void QuitGame()
    {
        // ���ø����̼��� �����Ѵ�.
        Application.Quit();
    }

    public void Button()
    {
        abc();
        showHideMenu();
        guide.SetActive(false);
        gState = GameState.Run;
    }

    public void showHideMenu()
    {
        if (PanelMenu != null)
        {
            Animator animator = PanelMenu.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("show");
                animator.SetBool("show", !isOpen);
            }
        }
    }
    public void abc()
    {
        Time.timeScale = 1f;
    }

}
