using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCP2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Book> books = new List<Book>()
        {
            new Book(){Title="숨", Writer="테드 창",Rank=3, Category="영미소설"},
            new Book(){Title="떨림과 울림", Writer="김상욱 ",Rank=2, Category="과학"},
            new Book(){Title="그림으로 나를 위로하는 밤", Writer="태지원",Rank=4, Category="교양인문"},
            new Book(){Title="베란다 채소밭", Writer="박희란",Rank=7, Category="정원"},
            new Book(){Title="일본어 상용한자 무작정 따라하기 1", Writer="권경배",Rank=5, Category="일본어"},
            new Book(){Title="당신의 인생이 왜 힘들지 않아야 한다고 생각하십니까", Writer="쇼펜하우어",Rank=6, Category="철학"},
            new Book(){Title="불편한 편의점", Writer="김호연",Rank=1, Category="한국소설"},
            new Book(){Title="장미의 이름", Writer="움베르토 에코",Rank=8, Category="기타 국가 소설"},
            new Book(){Title="새 먼나라 이웃나라", Writer="이원복",Rank=9, Category="역사 "},
            new Book(){Title="느림", Writer="밀란 쿤데라",Rank=10, Category="유럽소설"},
            new Book(){Title="데미안", Writer="헤르만 헤세",Rank=11, Category="독일소설"},
            new Book(){Title="구덩이", Writer="루이스 새커",Rank=12, Category="영미소설"},
            new Book(){Title="이상한 나라의 엘리스", Writer="루이스 캐럴",Rank=13, Category="어린이문학"},
            new Book(){Title="거울 나라의 엘리스", Writer="루이스 캐럴",Rank=14, Category="어린이문학"},
            new Book(){Title="인간의 조건", Writer="앙드레 말로",Rank=15, Category="인문"},
            new Book(){Title="죄와 벌", Writer="도스토예프스키",Rank=16, Category="러시아소설"},
            new Book(){Title="다시, 시로 읽는 세상", Writer="김용찬",Rank=17, Category="현대시"},
            new Book(){Title="과학 혁명의 구조", Writer="코머스 S.쿤",Rank=18, Category="과학"},
            new Book(){Title="부분과 전체", Writer="하이젠베르크",Rank=19, Category="과학"},
            new Book(){Title="갈릴레오 갈릴레이", Writer="브레히트",Rank=20, Category="역사"}
        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
