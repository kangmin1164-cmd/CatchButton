namespace CatchButton
{
    public partial class Form1 : Form
    {
        private int score = 1000;       // 현재 점수
        private int missCount = 0;      // 놓친 횟수 (감점 횟수)
        private const int MaxMiss = 20; // 게임 오버 기준

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Catch_Button_Click(object sender, EventArgs e)
        {

        }

        // 마우스가 버튼에 닿아 도망갈 때(MoseEnter 이벤트)
        private void Catch_Button_MouseEnter(object sender, EventArgs e)
        {
            //게임 오버 상태가 아닐 때만 도망감.
            if (missCount < MaxMiss)
            {
                score -= 10;  //도망갔으므로 10점 감점
                missCount++; // 놓친 횟수 증가

                //1. 난수생성기 준비
                Random rd = new Random();

                //2. 가용 영역 계산(버튼이 폼 테두리에 걸리지 않게 보호)
                //ClientSize(도화지 영역)에서 버튼의 너비와 높이를 빼줌.
                int maxX = this.ClientSize.Width - Catch_Button.Width;
                int maxY = this.ClientSize.Height - Catch_Button.Height;

                //만약 창이 너무 작아서 maxX나 maxY가 0보다 작아질 경우를 대비하여 안전장치
                if (maxX < 0) maxX = 0;
                if (maxY < 0) maxY = 0;

                // 3. 랜덤좌표추출(0 ~ 최대가용치사이)
                int nextX = rd.Next(0, maxX);
                int nextY = rd.Next(0, maxY);

                // 4. 위치할당(새로운Point 객체생성)
                Catch_Button.Location = new Point(nextX, nextY);

                // 5. 시각적피드백(폼제목표시줄에좌표출력)
                // this가 Form1을 가리킴
                this.Text = $"점수: {score}점 |버튼위치: ({nextX}, {nextY}) | 제한 범위: {maxX}, {maxY}";

                if (missCount >= MaxMiss)
                {
                    // 1. 버튼을 비활성화하고 게임 오버 메시지 표시
                    Catch_Button.Enabled = false;
                    this.Text = $"점수: {score}점 | GAME OVER!";

                    // 2. [예/아니오] 버튼이 있는 메시지 박스 띄우기
                    DialogResult result = MessageBox.Show(
                        $"게임 오버! 너무 많이 놓쳤어요.\n최종 점수: {score}점\n\n다시 시작하시겠습니까?",
                        "GAME OVER",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // 3. 사용자가 '예'를 눌렀을 때만 초기화 로직 실행
                    if (result == DialogResult.Yes)
                    {
                        // 모든 정보 초기화 (Reset 로직)
                        score = 1000;
                        missCount = 0;
                        Catch_Button.Enabled = true;
                        Catch_Button.Size = new Size(203, 110); // 처음 크기로 복구
                        Catch_Button.Location = new Point(100, 100); // 처음 위치로 복구
                        this.Text = $"게임을 다시 시작합니다! 점수: {score}점";
                    }
                }
                else
                {
                    // '아니오'를 누르면 프로그램 종료 (선택 사항)
                    // Application.Exit(); 
                }

            }
        }

        // 2. 마우스를 누르는 순간 잡는 기능 (MouseDown은 MouseEventArgs를 사용!)
        private void Catch_Button_MouseDown(object sender, MouseEventArgs e)
        {
            // [추가] 클릭 성공 시 100점 추가
            score += 100;

            // [추가] 버튼 크기 10% 축소 (현재 크기의 90%로 설정)
            int newWidth = (int)(Catch_Button.Width * 0.9);
            int newHeight = (int)(Catch_Button.Height * 0.9);

            // 너무 작아지면 아예 안 보일 수 있으므로 최소 크기(15px) 제한
            if (newWidth > 15 && newHeight > 15)
            {
                Catch_Button.Size = new Size(newWidth, newHeight);
            }

            System.Media.SystemSounds.Asterisk.Play();

            // 폼 제목 업데이트
            this.Text = $"점수: {score}점 | 성공! 버튼이 작아집니다.";

            MessageBox.Show("성공!");
        }
    }
}


