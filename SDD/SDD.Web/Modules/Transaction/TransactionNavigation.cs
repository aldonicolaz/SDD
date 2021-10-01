﻿using Serenity.Navigation;
using MyPages = SDD.Transaction.Pages;
[assembly: NavigationMenu(11000, "Pekerjaan", icon: "fa-credit-card")]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail User Peternakan Perikanan", typeof(MyPages.DetailUserPeternakanPerikananController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Pekerjaan/Perikanan Peternakan", typeof(MyPages.UserPerikananPeternakanController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Pekerjaan/Pertanian Perkebunan", typeof(MyPages.UserPertanianPerkebunanController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail User Perdagangan", typeof(MyPages.DetailUserPerdaganganController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Pekerjaan/Perdagangan", typeof(MyPages.UserPerdaganganController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail Kapal Nelayan", typeof(MyPages.DetailKapalNelayanController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Pekerjaan/Nelayan", typeof(MyPages.UserNelayanController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Pekerjaan/Karyawan", typeof(MyPages.UserKaryawanController), icon: null)]

//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail User Pertanian", typeof(MyPages.DetailUserPertanianController), icon: null)]

//[assembly: NavigationLink(int.MaxValue, "Master/Detail Flow Form", typeof(MyPages.DetailFlowFormController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Master/Master Flow Formulir", typeof(MyPages.MasterFlowFormulirController), icon: null)]
[assembly: NavigationMenu(11000, "Formulir", icon: "fa-file-excel-o")]

//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail Formulir Kk", typeof(MyPages.DetailFormulirKkController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Formulir/Formulir Kk", typeof(MyPages.FormulirKkController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Formulir/Formulir Ktp", typeof(MyPages.FormulirKtpController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail Akta Lahir", typeof(MyPages.DetailAktaLahirController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Formulir/Formulir Akta Kelahiran", typeof(MyPages.FormulirAktaKelahiranController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Formulir/Approval Pengajuan", typeof(MyPages.TransaksiStatusController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Fcm Message", typeof(MyPages.FcmMessageController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Broadcast Message", typeof(MyPages.ParentMessageController), icon: "fa-bullhorn")]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Fcm Message User", typeof(MyPages.FcmMessageUserController), icon: null)]

[assembly: NavigationMenu(11000, "Desa", icon: "fa-institution")]
[assembly: NavigationLink(int.MaxValue, "Desa/Banner", typeof(MyPages.BannerController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Desa/Info Desa", typeof(MyPages.InfoDesaController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Desa/Aparatur Desa", typeof(MyPages.AparaturDesaController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail Forum", typeof(MyPages.DetailForumController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Forum", typeof(MyPages.ForumController), icon: "fa-cubes")]
//[assembly: NavigationLink(int.MaxValue, "Forum", typeof(MyPages.ForumNewController), icon: "fa-cubes")]
//[assembly: NavigationLink(int.MaxValue, "Transaction/Detail Pengaduan", typeof(MyPages.DetailPengaduanController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Pengaduan", typeof(MyPages.PengaduanController), icon: "fa-comments-o")]