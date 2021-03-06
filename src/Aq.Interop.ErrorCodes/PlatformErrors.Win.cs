﻿namespace Aq.Interop {
    partial class PlatformErrors {
        public class Win : Base {
            /* platform missing */
            public override int ENOTBLK                 => int.MaxValue;
            public override int ESOCKTNOSUPPORT         => int.MaxValue;
            public override int EPFNOSUPPORT            => int.MaxValue;
            public override int ESHUTDOWN               => int.MaxValue;
            public override int ETOOMANYREFS            => int.MaxValue;
            public override int EHOSTDOWN               => int.MaxValue;
            public override int EPROCLIM                => int.MaxValue;
            public override int EUSERS                  => int.MaxValue;
            public override int EDQUOT                  => int.MaxValue;
            public override int ESTALE                  => int.MaxValue;
            public override int EREMOTE                 => int.MaxValue;
            public override int EBADRPC                 => int.MaxValue;
            public override int ERPCMISMATCH            => int.MaxValue;
            public override int EPROGUNAVAIL            => int.MaxValue;
            public override int EPROGMISMATCH           => int.MaxValue;
            public override int EPROCUNAVAIL            => int.MaxValue;
            public override int EFTYPE                  => int.MaxValue;
            public override int EAUTH                   => int.MaxValue;
            public override int ENEEDAUTH               => int.MaxValue;
            public override int EPWROFF                 => int.MaxValue;
            public override int EDEVERR                 => int.MaxValue;
            public override int EBADEXEC                => int.MaxValue;
            public override int EBADARCH                => int.MaxValue;
            public override int ESHLIBVERS              => int.MaxValue;
            public override int EBADMACHO               => int.MaxValue;
            public override int ENOATTR                 => int.MaxValue;
            public override int EMULTIHOP               => int.MaxValue;
            public override int ENOPOLICY               => int.MaxValue;

            public override int EPERM                   => 1;
            public override int ENOENT                  => 2;
            public override int ESRCH                   => 3;
            public override int EINTR                   => 4;
            public override int EIO                     => 5;
            public override int ENXIO                   => 6;
            public override int E2BIG                   => 7;
            public override int ENOEXEC                 => 8;
            public override int EBADF                   => 9;
            public override int ECHILD                  => 10;
            public override int EAGAIN                  => 11;
            public override int ENOMEM                  => 12;
            public override int EACCES                  => 13;
            public override int EFAULT                  => 14;
            public override int EBUSY                   => 16;
            public override int EEXIST                  => 17;
            public override int EXDEV                   => 18;
            public override int ENODEV                  => 19;
            public override int ENOTDIR                 => 20;
            public override int EISDIR                  => 21;
            public override int ENFILE                  => 23;
            public override int EMFILE                  => 24;
            public override int ENOTTY                  => 25;
            public override int EFBIG                   => 27;
            public override int ENOSPC                  => 28;
            public override int ESPIPE                  => 29;
            public override int EROFS                   => 30;
            public override int EMLINK                  => 31;
            public override int EPIPE                   => 32;
            public override int EDOM                    => 33;
            public override int EDEADLK                 => 36;
            public override int ENAMETOOLONG            => 38;
            public override int ENOLCK                  => 39;
            public override int ENOSYS                  => 40;
            public override int ENOTEMPTY               => 41;

            public override int EINVAL                  => 22;
            public override int ERANGE                  => 34;
            public override int EILSEQ                  => 42;
            public override int STRUNCATE               => 80;

            public override int EDEADLOCK               => this.EDEADLK;

            public override int EADDRINUSE              => 100;
            public override int EADDRNOTAVAIL           => 101;
            public override int EAFNOSUPPORT            => 102;
            public override int EALREADY                => 103;
            public override int EBADMSG                 => 104;
            public override int ECANCELED               => 105;
            public override int ECONNABORTED            => 106;
            public override int ECONNREFUSED            => 107;
            public override int ECONNRESET              => 108;
            public override int EDESTADDRREQ            => 109;
            public override int EHOSTUNREACH            => 110;
            public override int EIDRM                   => 111;
            public override int EINPROGRESS             => 112;
            public override int EISCONN                 => 113;
            public override int ELOOP                   => 114;
            public override int EMSGSIZE                => 115;
            public override int ENETDOWN                => 116;
            public override int ENETRESET               => 117;
            public override int ENETUNREACH             => 118;
            public override int ENOBUFS                 => 119;
            public override int ENODATA                 => 120;
            public override int ENOLINK                 => 121;
            public override int ENOMSG                  => 122;
            public override int ENOPROTOOPT             => 123;
            public override int ENOSR                   => 124;
            public override int ENOSTR                  => 125;
            public override int ENOTCONN                => 126;
            public override int ENOTRECOVERABLE         => 127;
            public override int ENOTSOCK                => 128;
            public override int ENOTSUP                 => 129;
            public override int EOPNOTSUPP              => 130;
            public override int EOTHER                  => 131;
            public override int EOVERFLOW               => 132;
            public override int EOWNERDEAD              => 133;
            public override int EPROTO                  => 134;
            public override int EPROTONOSUPPORT         => 135;
            public override int EPROTOTYPE              => 136;
            public override int ETIME                   => 137;
            public override int ETIMEDOUT               => 138;
            public override int ETXTBSY                 => 139;
            public override int EWOULDBLOCK             => 140;
        }
    }
}
