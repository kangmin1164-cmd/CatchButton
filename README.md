# 버튼잡기게임(C# 코딩)
## 개요
-C# 프로그래밍학습
-핵심기능: 버튼에 마우스를 올리면 버튼이 도망가며 도망가는 버튼을 잡아 점수를 늘려야한다. 

-화면구성: 시작 창, 버튼, (20번 놓칠 시) GAME OVER창(다시 시작 버튼을 포함)

## 실행화면
-1단계코드의실행스크린샷(여기에이미지삽입)
<img width="799" height="469" alt="image" src="https://github.com/user-attachments/assets/ba1d8e85-d772-4ac4-8aa4-61b99c4c09fa" />

Ui구성(Text는 "나를 잡아봐")
버튼 이동 구현(마우스가 버튼 위로 이동하면 버튼의 위치를 변경해서 옮겨짐)
버튼 위치 정보를 폼 제목에 실시간으로 표시
버튼 이동 범위가 창 밖으로 나가지 않게끔 방지함

-2단계코드의실행스크린샷(여기에이미지삽입)
<img width="798" height="473" alt="image" src="https://github.com/user-attachments/assets/c36e33d5-cdfd-4fbf-bf2e-dd5e616c1355" />

버튼을 잡았을 때 놓쳤을 때 다른 소리를 출력
버튼을 잡았을 때 메세지 박스를 띄움


-3단계코드의실행스크린샷(여기에이미지삽입)
<img width="801" height="474" alt="image" src="https://github.com/user-attachments/assets/3644d63d-370f-4a8c-9ddb-dfa3029ee2b6" />

<img width="796" height="478" alt="image" src="https://github.com/user-attachments/assets/5145c4a7-768f-4e2d-aa56-59e8bdbb38e7" />

점수 계산(기본 점수 1000점을 가지고 시작하며 잡을때마다 +100점, 놓칠때마다 -10점을 계산하여 폼 제목에 점수를 표시)
난이도 조절(클릭에 성공할 때마다 버튼의 크기를 10% 작게 축소)

-4단계코드의실행스크린샷(여기에이미지삽입)
<img width="803" height="477" alt="image" src="https://github.com/user-attachments/assets/9bc81672-f2cd-41c6-b785-e592d613a123" />

20번 이상 놓칠 시 게임 오버 창 출력(모든 버튼이 비활성화 되어 게임을 할 수 없게끔 함.
다시시작 버튼 구현(게임 오버 창에 Yes or No 선택 버튼으로 게임을 리셋하여 다시 하거나 종료하게끔 버튼 생성)

## 구현시어려웠던점
소리 출력을 찾기위해서 도구 상자에서 찾다가 윈도우 소리가 내장되어있어 사용할 수 있다는 사실을 깨닳고 뒤늦게 적용함.
다시시작 버튼을 구현하기 위해 Fomr자체에 버튼을 하나 더 생성하여 만들다가 게임 플레이에 방해가 될 수 있음을 알고 게임오버 창에서 다시하기 버튼을 구현하도록 바꾸기 위해 제미나이에게 물어봐서 해결하였음.
