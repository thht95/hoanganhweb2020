function kiemTra() {
    var taiKhoan = document.getElementById("txtTaiKhoan").value;
    var matKhau = document.getElementById("txtMatKhau").value;
    var loiTaiKhoan = document.getElementById("loiTaiKhoan");
    var loiMatKhau = document.getElementById("loiMatKhau");

    if (taiKhoan == "" || matKhau == "") {
        loiMatKhau.style.display = "block";
        loiTaiKhoan.style.display = "block";
        if (taiKhoan == "")
            loiTaiKhoan.innerHTML = "Bạn chưa nhập tài khoản!";
        if (matKhau == "")
            loiMatKhau.innerHTML = "Bạn chưa nhập mật khẩu";
        return false;
    }
    else if (matKhau.length < 6) {
        loiMatKhau.style.display = "block";
        loiTaiKhoan.style.display = "none";
        loiMatKhau.innerHTML = "Mật khẩu phải từ 6 ký tự trở lên";
        return false;
    }
    else {
        loiMatKhau.style.display = "none";
        loiTaiKhoan.style.display = "none";
        return true;
    }
}
function toDangKy() {
    window.location = "DangKy.aspx";
}