namespace CatchButton
{
    public partial class Form1 : Form
    {
        private int score = 1000;

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
        
        private void Catch_Button_MouseEnter(object sender, EventArgs e)
        {
            //도망갔으므로 10점 감점
            score -= 10;

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


