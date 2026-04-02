namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false; // 에러 메시지 숨기기

            if (txtUserId.Text == "아이디") // 현재 플레이스홀더인지 확인
            {
                txtUserId.Text = ""; // 안내문 제거
                txtUserId.ForeColor = Color.Black; // 입력 글자색 검정으로 변경
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (txtUserId.Text == "") // 아무것도 입력하지 않았으면
            {
                txtUserId.Text = "아이디"; // 다시 플레이스홀더 표시
                txtUserId.ForeColor = Color.Gray; // 안내문 색 회색으로 변경
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "비밀번호") // 현재 플레이스홀더인지 확인
            {
                lblErrorMessage.Visible = false; // 에러 메시지 숨기기

                txtPassword.Text = ""; // 안내문 제거
                txtPassword.ForeColor = Color.Black; // 입력 글자색 검정으로 변경
                txtPassword.UseSystemPasswordChar = true; // 비밀번호 가리기 시작
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") // 아무것도 입력하지 않았으면
            {
                txtPassword.UseSystemPasswordChar = false; // 플레이스홀더 보이게 마스킹 해제
                txtPassword.Text = "비밀번호"; // 다시 플레이스홀더 표시
                txtPassword.ForeColor = Color.Gray; // 안내문 색 회색으로 변경
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text; // 아이디 값 저장
            string password = txtPassword.Text; // 비밀번호 값 저장

            if (userId == "human" && password == "1234") // 둘 다 맞는지 확인
            {
                lblErrorMessage.Visible = false; // 에러 메시지 숨기기
                MessageBox.Show("로그인 성공"); // 성공 메시지 박스 출력
            }
            else // 하나라도 틀리면
            {
                lblErrorMessage.Visible = true; // 에러 메시지 보이기
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Enter 키 눌렀을 때
            {
                btnLogin_Click(sender, e); // 로그인 버튼 클릭 이벤트 실행
            }
        }
    }
}
