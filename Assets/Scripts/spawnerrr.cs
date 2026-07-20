











































//{
//    [Header("Что спавнить:")]
//    [SerializeField]
//    private GameObject prefab;

//    [Header("Где спавнить:")]
//    [SerializeField]
//    private Transform[] spawnPoint;

//    private int Count=0;

//    [Header("LifeTime")]
//    [SerializeField]
//    private float destroyAfter = 5f;
//    public bool Lever = true;





//    private void Awake()
//    {
//        //if (spawnPoint == null)
//        //{
//        //    spawnPoint = transform;
//        //}
//    }
//    private void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            Spawn();

//        }
//    }
//    public void Spawn()

//    {


//        if (prefab == null) return;

//        Transform trone = spawnPoint[Count];



//       GameObject obj = Instantiate(prefab, trone.position, trone.rotation);
//            //if (destroyAfter > 0f)

//        Destroy(obj, destroyAfter);
//        //obj.SetActive(false);




//        Count = (Count + 1) % spawnPoint.Length;
//        Debug.Log(Count);
//        if (Count >= spawnPoint.Length)
//        {

//            Count = 0;
//        }


//    }

//}
////ctrl f 