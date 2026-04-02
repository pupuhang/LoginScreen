namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 로그인에 사용할 아이디와 비밀번호
        string myID = "human";
        string myPW = "1234";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text; // 아이디 값 저장
            string inputPW = txtPW.Text; // 비밀번호 값 저장

            if (inputID == myID && inputPW == myPW) // 둘 다 맞는지 확인
            {
                lblErrorMsg.Visible = false; // 에러 메시지 숨기기
                MessageBox.Show("로그인 성공", "로그인", MessageBoxButtons.OK); // 성공 메시지 박스 출력
            }
            else
            {
                lblErrorMsg.Visible = true; // 에러 메시지 출력
                // 실패 메시지 출력
                MessageBox.Show("로그인 실패", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            // 에러 메시지 숨기기
            lblErrorMsg.Visible = false;
            // 현재 플레이스홀더인지 확인
            if (txtID.Text == "아이디")
            {
                // 안내문 제거
                txtID.Text = "";
                // 입력 글자색 검정으로 변경
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                // 다시 플레이스홀더 표시
                txtID.Text = "아이디";
                // 안내문 색 변경
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            // 현재 플레이스홀더인지 확인
            if (txtPW.Text == "패스워드")
            {
                // 에러 메시지 숨기기
                lblErrorMsg.Visible = false;
                txtPW.Text = ""; // 안내문 제거
                txtPW.UseSystemPasswordChar = true; // 비밀번호 가리기 시작
                txtPW.ForeColor = Color.Black; // 입력 글자색 검정으로 변경
                
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (txtPW.Text == "") // 아무것도 입력하지 않았으면
            {
                txtPW.UseSystemPasswordChar = false; // 플레이스홀더 보이게 마스킹 해제
                txtPW.Text = "패스워드"; // 다시 플레이스홀더 표시
                txtPW.ForeColor = Color.Silver; // 안내문 색 변경
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                txtPW.Focus(); // 패스워드입력창이포커스를갖게끔
            }
        }


        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                btnLogin.PerformClick(); // 버튼이눌린것처럼만들기
            }
        }
    }
}
