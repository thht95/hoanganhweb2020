function kiemTra() {
    var taiKhoan = document.getElementById("txtTaiKhoan").value;
    var matKhau = document.getElementById("txtMatKhau").value;
    var matKhau2 = document.getElementById("txtMatKhau2").value;
    var loiTaiKhoan = document.getElementById("loiTaiKhoan");
    var loiMatKhau = document.getElementById("loiMatKhau");
    var loiMatKhau2 = document.getElementById("loiMatKhau2");

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
    else if (matKhau != matKhau2) {
        loiMatKhau.style.display = "none";
        loiTaiKhoan.style.display = "none";
        loiMatKhau2.style.display = "block";
        loiMatKhau2.innerHTML = "Mật khẩu không khớp";
        return false;
    }
    else {
        loiMatKhau.style.display = "none";
        loiTaiKhoan.style.display = "none";
        loiMatKhau2.style.display = "none";
        return true;
    }

}
