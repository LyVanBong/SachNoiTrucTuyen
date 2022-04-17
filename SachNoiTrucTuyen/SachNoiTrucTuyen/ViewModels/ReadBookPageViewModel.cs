using Prism.Mvvm;

namespace SachNoiTrucTuyen.ViewModels
{
    public class ReadBookPageViewModel : BindableBase
    {
        public string BookContent { get; set; }

        public ReadBookPageViewModel()
        {
            SetSourceContent();
        }

        public void SetSourceContent()
        {
            BookContent = "<p>Hãy bắt tôi nếu bạn có thể là một người Mỹ năm 2002 tiểu sử phim tội phạm được đạo diễn và sản xuất bởi Steven Spielberg từ một kịch bản của Jeff Nathanson.Các ngôi sao điện ảnh Leonardo DiCaprio và Tom Hanks, với Christopher Walken, Martin Sheenvà Nathalie Baye trong các vai phụ.Bộ phim dựa trên cuộc đời của Frank Abagnale, trước sinh nhật lần thứ 19 của mình, đã thực hiện thành công khuyết điểm trị giá hàng triệu đô la bằng cách giả dạng Pan American World Airways phi công, một bác sĩ Georgia và một Louisiana giáo xứ công tố viên.Tội ác lớn nhất của anh ta là kiểm tra gian lận; anh ấy trở nên có kỹ năng cao đến mức FBI sau đó quay sang anh ta để được giúp bắt những kẻ giả mạo séc khác.</p>"
                          + "<p></p>"
                          + "<p></p>"
                          + "<p></p>"
                          + "<p>Quá trình phát triển cho bộ phim bắt đầu vào năm 1980 nhưng kéo dài cho đến năm 1997, khi Spielberg's DreamWorks đã mua bản quyền phim để Cuốn sách cùng tên năm 1980 của Abagnale. David Fincher, Gore Verbinski, Lasse Hallström, Miloš Formanvà Cameron Crowe đều được cân nhắc để đạo diễn bộ phim trước khi Spielberg quyết định tự mình đạo diễn. Quá trình quay phim diễn ra từ tháng 2 đến tháng 5 năm 2002.</p>"
                          + "<p></p>"
                          + "<p></p>"
                          + "<p>Bộ phim khởi chiếu vào ngày 25 tháng 12 năm 2002 với thành công về mặt phê bình và thương mại.Tại Giải thưởng Viện hàn lâm lần thứ 75, Christopher Walken và John Williams đã được đề cử cho Nam diễn viên phụ xuất sắc nhất và Giá gốc tốt nhất, [2] tương ứng.</p>"
                          + "<p></p>"
                          + "</br>"
                          + "<p><b>Âm mưu</b></p>"
                          + "<p>Năm 1963, thiếu niên Frank Abagnale sống ở New Rochelle, New York với cha Frank Abagnale Sr.và mẹ người Pháp, Paula.Khi Frank Sr.gặp phải các vấn đề về thuế với IRS, gia đình anh buộc phải chuyển từ ngôi nhà lớn của họ đến một căn hộ nhỏ.Trong khi đó, Frank phải chuyển đến trường công lập và gặp rắc rối khi bắt đầu đóng vai một giáo viên dạy tiếng Pháp thay thế trong ngày đầu tiên đến đây. Ngay sau đó, Frank phát hiện ra mẹ mình ngoại tình với Jack Barnes, bạn của bố anh. Frank bỏ trốn khi bố mẹ ly hôn. Cần tiền, anh ta quay sang lừa đảo lòng tin để tồn tại và khuyết điểm của anh ta ngày càng táo bạo hơn. Anh ta mạo danh một phi công và rèn Pan Am kiểm tra bảng lương.Chẳng bao lâu, đồ rèn của anh ấy trị giá hàng triệu đô la.</p>"
                          + "<p></p>"
                          + "</br>"
                          + "<p></p>"
                          + "<p>FBI đặc vụ Carl Hanratty bắt đầu theo dõi Frank. Carl tìm thấy Frank tại một khách sạn, nhưng Frank khuyên Carl tin rằng anh ta là một Dịch vụ bí mật đặc vụ cũng đang theo đuổi kẻ lừa đảo, và trốn thoát trước khi Carl nhận ra rằng mình đã bị lừa.</p>"
                          + "<p></p>"
                          + "</br>"
                          + "<p>Frank bắt đầu đóng giả một Bác sĩ và một luật sư. Trong vai bác sĩ Frank Conners, anh phải lòng Brenda, một nhân viên bệnh viện trẻ ngây thơ. Anh ta yêu cầu cha luật sư của Brenda cho phép kết hôn với cô ấy, và cũng muốn ông giúp đỡ trong việc thu xếp để đưa Louisiana State Bar kỳ thi mà Frank vượt qua.Carl theo dõi Frank đến bữa tiệc đính hôn của anh và Brenda, nhưng Frank đã trốn thoát qua cửa sổ phòng ngủ vài phút trước khi Carl đến gặp anh. Trước khi rời đi, Frank yêu cầu Brenda gặp anh ta tại sân bay Miami hai ngày sau đó.Tại sân bay, Frank nhìn thấy Brenda, nhưng cũng phát hiện các đặc vụ mặc thường phục ở khắp mọi nơi và nhận ra Brenda đã phản bội anh ta.Frank sau đó giả định lại danh tính của mình là một phi công Pan Am và chuẩn bị một đợt tuyển dụng giả cho các tiếp viên tại một trường cao đẳng địa phương.Anh ta tuyển tám phụ nữ làm tiếp viên, che giấu mình khỏi Carl và các đặc vụ khác khi đi bộ qua sân bay Miami với các tiếp viên và trốn thoát trên một chuyến bay tới Madrid, Tây Ban Nha.</p>"
                          + "<p></p>"
                          + "</br>"
                          + "<p>Carl cuối cùng cũng theo dõi Frank trong Montrichard, Pháp, quê hương của mẹ anh.Frank được đưa đến một nhà tù của Pháp, nhưng gần như chết hai năm sau đó do điều kiện tồi tệ. Trước khi hạ cánh, Carl thông báo cho Frank rằng Frank Sr. đã chết. Quá đau buồn, Frank trốn thoát khỏi máy bay và đến nơi mẹ và cha dượng đang sống.Khi cảnh sát đến, Frank đầu hàng sau khi chứng kiến ​​mẹ anh tiếp tục cuộc sống của bà và có một cô con gái nhỏ.Anh ta bị kết án 12 năm trong một nhà tù an ninh tối đa.</p>"
                          + "<p></p>"
                          + "</br>"
                          + "<p>Carl thỉnh thoảng đến thăm anh ta.Trong một lần đến thăm, Carl đưa cho Frank xem một tấm séc từ một vụ án mà anh ta đang làm, và Frank ngay lập tức xác định rằng nhân viên giao dịch ngân hàng có liên quan.Carl ấn tượng thuyết phục FBI cho phép Frank thụ án phần còn lại của mình làm việc cho đơn vị lừa đảo ngân hàng FBI. Frank đồng ý, nhưng thấy công việc tẻ nhạt và gò bó và nhớ cuộc sống cũ của mình.</p>"
                          + "<p></p>"
                          + "</br>"
                          + "<p>Một ngày cuối tuần, anh ấy lại thử bay với tư cách là một phi công hàng không. Anh ta bị chặn lại bởi Carl, người muốn Frank quay lại FBI vào thứ Hai và đảm bảo với Frank rằng không ai đang đuổi theo anh ta. Vào thứ Hai, Carl trở nên lo lắng khi Frank vẫn chưa đến văn phòng. Tuy nhiên, cuối cùng Frank cũng xuất hiện, và họ thảo luận về trường hợp tiếp theo.</p>"
                          + "<p></p>"
                          + "</br>"
                          + "<p>Đoạn cuối tiết lộ rằng Frank là có thật và đã kết hôn được 26 năm, có ba con trai, sống ở Trung Tây và duy trì tình bạn với Carl.Giờ đây, anh kiếm được hàng triệu đô la với tư cách là một chuyên gia bảo mật ngân hàng, đã thiết kế séc ngân hàng an toàn và đã giúp bắt nhiều kẻ giả mạo.</p>";
        }
    }
}