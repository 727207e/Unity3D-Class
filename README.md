# 3D Mini Proejct List


1. 유승호


https://user-images.githubusercontent.com/54798151/201524924-7b47e977-5792-462a-9805-d2523c3d673f.mp4


https://github.com/treelun/3DProject/tree/main/Defence

Avcorad (RPG)

믹사모에서 애니메이션 및 캐릭터를 가져옴.
믹사모 애니메이션이 유니티에 딱 맞지않기때문에
애니메이션을 수정함 (T포즈 아바타를 가지고와서 맞지않는 애니메이션을 조절해서 쓸수 있도록 변경함)

마왕이 용을 조종해서 Avcorad라는 나라를 부숨
용사가 이를 구원하고자 떠나는 여행 이야기


Animation 때문에 시간을 많이 소비함

터레인과 AssetStore로 맵 제작

UI제작으로 체력 및 마나, 스테미너 구현

공격/ 구르기로 스테미너 감소

구르기시에 레이어 변경으로 무적

적 - 콜라이더 범위로 들어온 플레이어를 추적함
추격할땐 애니메이션 이동속도를 변경해서 빠르게 다가옴
상단에 체력바 구현
적군의 공격에 딜레이를 구현
적군 피격시 빨간색 변경으로 피격을 시각적으로 표현
적군이 플레이어를 발견하지 못하면 서성거림.

플레이어 - 스테미너가 모두 소모되면 못움직임
적을 공격하면 파티클 효과 발생
플레이어는 최대 3번 연속 공격을 가능함


2. 태욱

https://github.com/taewook06/3dHorror

3dHorror (공포 서바이벌)

맵에 랜덤하게 열쇠를 생성함.

문에 가까이가서 e를 누르면 문이 열림

메테리얼 제작으로 라디오 직접 제작( 클릭시 소리 플레이 )

직접 제작한 미로 제작 및 제작한 미로를 이미지로 캡쳐진행.
플레인 위에 이미지를 넣어서 액자처럼 제작을 함.

벽 한쪽 면에 랜덤한 숫자를 띄움.
랜덤한 숫자에 맞춰 게임에 나오는 방 넘버 순서대로 불을 키면(상호작용을 하면) 다음 단계로 진행할 수 있음.

오브젝트 충돌 체크를 진행해서 몸으로 박스를 밀고 진행함.

촬영한 귀신 튀어나오는 동영상을 플레인에 삽입해서 동영상  연출을 진행함.

CCTV같은 위치에 PointLight, 등장하는 귀신들에겐 SpotLight들을 사용해서 시각적 연출을 진행함.

몬스터가 플레이어를 쫓아오는건 NavMesh를 사용해서 제작함.


3. 재광

https://github.com/jk77621/unityclass/tree/main/Assignment04

콘크리트 (자동차 레이싱)

UI버튼으로 차량을 고를 수 있음.
초기화면에서 돈으로 차량을 구매(언락)할 수 있음.
구매시 돈이 차감됨.

속도에 따른 계기판 변경 (기어, 속도)

계기판에 부스터를 쓸 수 있는 게이지가 표시됨.
부스터를 사용해서 게이지 소모하고 속도를 증가함.

부스터 사용시 배출구에서 파티클 진행.

왼쪽에 등수를 표현함.

결과 표시창으로 몇등인지 보여줌.
확인 버튼 누르면 다시 로비 화면으로 이동(씬 이동)

WayPoint를 사용해서 AI가 이동해야 하는 경로를 만듬.
Node를 찍어서 다음 이동해야 하는 노드와의 거리를 계산.
지나가면 다음 노드로 이동하도록 실행함.

smoothDamp를 사용해서 플레이어가 드리프트할때 자연스럽게 이동하도록 함.
특정 속도에서 기어가 자동으로 변경하도록 진행.
기어가 높을 수록 빨라짐.

TrailRenderer을 사용해서 드레프트를 할때 흔적이 남도록 함.

카메라를 자동차 진행방향으로 보도록 자연스럽게 회전.
자동차라 물리 연산때문에 뒤집어 지는 것을 방지하고자 오브젝트를 아래쪽으로 누르는 힘(중력)을 수정함.

4. 준겸

Lonely Shelter (서바이벌 디팬스)

터레인으로 맵 제작
시간에 흐름에 따라 해(Directional Light)가 회전해서 해가 지는 것을 표현함.

밤시간이 되면 Enviroment의 Fog를 수정해서 플레이어의 시야를 좁힘.

좀비가 플레이어를 따라옴.
해당 AI는 NaviMesh를 사용함.

NavMesh위에 랜덤한 위치로 좀비가 생성이 됨.
생성된 좀비는 플레이어와 일정거리 가까워지면 좀비가 플레이어를 쫓아온다.

