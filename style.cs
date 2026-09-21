* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

html {
    scroll-behavior: smooth;
}

body {
    font-family: "Inter", sans-serif;
    background: #07111f;
    color: #ffffff;
    line-height: 1.6;
}

a {
    text-decoration: none;
    color: inherit;
}

.container {
    width: 90%;
    max-width: 1180px;
    margin: auto;
}


/* =========================
   NAVBAR
========================= */

.navbar {
    width: 100%;
    padding: 22px 0;
    background: rgba(7, 17, 31, 0.92);
    border-bottom: 1px solid rgba(255, 255, 255, 0.07);
    position: sticky;
    top: 0;
    z-index: 1000;
    backdrop-filter: blur(15px);
}

.nav-content {
    display: flex;
    align-items: center;
    justify-content: space-between;
}

.logo {
    font-size: 24px;
    font-weight: 800;
    letter-spacing: -1px;
}

.logo span:last-child {
    color: #55e6a5;
}

.logo-icon {
    color: #55e6a5;
    margin-right: 5px;
}

nav {
    display: flex;
    gap: 35px;
}

nav a {
    color: #a9b5c5;
    font-size: 14px;
    transition: 0.3s;
}

nav a:hover {
    color: #55e6a5;
}

.nav-button {
    padding: 10px 20px;
    border: 1px solid #55e6a5;
    border-radius: 7px;
    color: #55e6a5;
    font-size: 14px;
    transition: 0.3s;
}

.nav-button:hover {
    background: #55e6a5;
    color: #07111f;
}


/* =========================
   HERO
========================= */

.hero {
    min-height: 700px;
    display: flex;
    align-items: center;
    background:
        radial-gradient(circle at 75% 35%, rgba(56, 189, 248, 0.12), transparent 30%),
        radial-gradient(circle at 20% 50%, rgba(85, 230, 165, 0.08), transparent 30%);
}

.hero-content {
    display: grid;
    grid-template-columns: 1fr 0.85fr;
    gap: 80px;
    align-items: center;
}

.badge {
    display: inline-flex;
    align-items: center;
    gap: 9px;
    padding: 8px 14px;
    border-radius: 50px;
    border: 1px solid rgba(85, 230, 165, 0.25);
    background: rgba(85, 230, 165, 0.06);
    color: #8cf2c2;
    font-size: 12px;
    margin-bottom: 25px;
}

.pulse {
    width: 7px;
    height: 7px;
    background: #55e6a5;
    border-radius: 50%;
    box-shadow: 0 0 12px #55e6a5;
}

.hero h1 {
    font-size: clamp(45px, 6vw, 75px);
    line-height: 1.02;
    letter-spacing: -4px;
    margin-bottom: 25px;
}

.hero h1 span {
    color: #55e6a5;
}

.hero-text > p {
    color: #9aa9bc;
    max-width: 570px;
    font-size: 17px;
    margin-bottom: 35px;
}

.hero-buttons {
    display: flex;
    gap: 15px;
    flex-wrap: wrap;
}

.primary-button {
    display: inline-block;
    padding: 14px 24px;
    background: #55e6a5;
    color: #06111e;
    font-weight: 700;
    border-radius: 7px;
    transition: 0.3s;
}

.primary-button:hover {
    transform: translateY(-3px);
    box-shadow: 0 10px 30px rgba(85, 230, 165, 0.2);
}

.secondary-button {
    padding: 14px 24px;
    border: 1px solid #344255;
    border-radius: 7px;
    color: #dce5ee;
    transition: 0.3s;
}

.secondary-button:hover {
    border-color: #55e6a5;
    color: #55e6a5;
}

.trusted {
    display: flex;
    align-items: center;
    gap: 15px;
    margin-top: 45px;
}

.trusted strong {
    display: block;
    font-size: 15px;
}

.trusted small {
    color: #718197;
}

.avatars {
    display: flex;
}

.avatars span {
    width: 35px;
    height: 35px;
    border-radius: 50%;
    background: #152438;
    border: 2px solid #07111f;
    display: flex;
    justify-content: center;
    align-items: center;
    margin-left: -8px;
    color: #55e6a5;
    font-size: 12px;
}

.avatars span:first-child {
    margin-left: 0;
}


/* =========================
   TERMINAL
========================= */

.terminal {
    background: #0b1727;
    border: 1px solid #26364b;
    border-radius: 13px;
    overflow: hidden;
    box-shadow: 0 30px 70px rgba(0, 0, 0, 0.35);
    transform: perspective(1000px) rotateY(-4deg);
}

.terminal-header {
    height: 48px;
    display: flex;
    align-items: center;
    padding: 0 18px;
    background: #101e30;
    border-bottom: 1px solid #26364b;
}

.dots {
    display: flex;
    gap: 6px;
}

.dots span {
    width: 10px;
    height: 10px;
    border-radius: 50%;
    background: #435268;
}

.terminal-title {
    flex: 1;
    text-align: center;
    color: #74849a;
    font-size: 12px;
}

.terminal-body {
    padding: 30px;
    min-height: 350px;
    font-family: monospace;
    font-size: 14px;
}

.terminal-body p {
    margin-bottom: 18px;
    color: #d5deea;
}

.green,
.success {
    color: #55e6a5 !important;
}

.yellow {
    color: #f3c969 !important;
}

.cursor {
    animation: blink 1s infinite;
}

@keyframes blink {
    50% {
        opacity: 0;
    }
}


/* =========================
   SERVICES
========================= */

.services {
    padding: 120px 0;
    background: #0a1625;
}

.section-heading {
    text-align: center;
    max-width: 700px;
    margin: auto;
    margin-bottom: 60px;
}

.section-heading > span,
.section-label,
.cta-box > div > span {
    color: #55e6a5;
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 2px;
}

.section-heading h2 {
    font-size: 42px;
    line-height: 1.2;
    margin: 15px 0;
}

.section-heading h2 strong {
    color: #55e6a5;
}

.section-heading p {
    color: #7e8da1;
}

.service-grid {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 18px;
}

.service-card {
    padding: 30px 25px;
    border: 1px solid #243448;
    border-radius: 12px;
    background: #0d1b2d;
    transition: 0.3s;
}

.service-card:hover {
    transform: translateY(-8px);
    border-color: #55e6a5;
}

.service-icon {
    width: 50px;
    height: 50px;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 10px;
    background: rgba(85, 230, 165, 0.08);
    color: #55e6a5;
    font-size: 23px;
    margin-bottom: 25px;
}

.service-card h3 {
    margin-bottom: 12px;
    font-size: 18px;
}

.service-card p {
    color: #7e8da1;
    font-size: 14px;
    margin-bottom: 25px;
}

.service-card a {
    color: #55e6a5;
    font-size: 13px;
    font-weight: 600;
}


/* =========================
   ABOUT
========================= */

.about {
    padding: 120px 0;
}

.about-content {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 100px;
    align-items: center;
}

.about-text h2 {
    font-size: 45px;
    line-height: 1.15;
    margin: 18px 0;
}

.about-text h2 span {
    color: #55e6a5;
}

.about-text > p {
    color: #8493a7;
    max-width: 520px;
}

.features {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 15px;
    margin-top: 30px;
}

.features div {
    color: #c5cfda;
    font-size: 14px;
}

.features strong {
    color: #55e6a5;
    margin-right: 8px;
}

.stats {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 15px;
}

.stat {
    padding: 35px 25px;
    background: #0d1b2d;
    border: 1px solid #243448;
    border-radius: 12px;
}

.stat h3 {
    font-size: 34px;
    color: #55e6a5;
}

.stat p {
    color: #738297;
    font-size: 14px;
}


/* =========================
   CTA
========================= */

.cta {
    padding: 80px 0;
    background: #0a1625;
}

.cta-box {
    padding: 55px;
    border: 1px solid #293b50;
    border-radius: 16px;
    background:
        radial-gradient(circle at 80% 50%, rgba(85, 230, 165, 0.09), transparent 30%),
        #0d1b2d;
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 30px;
}

.cta-box h2 {
    font-size: 35px;
    margin: 10px 0;
}

.cta-box h2 strong {
    color: #55e6a5;
}

.cta-box p {
    color: #7e8da1;
}


/* =========================
   FOOTER
========================= */

footer {
    padding: 30px 0;
    border-top: 1px solid #1d2b3c;
}

.footer-content {
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 20px;
}

.footer-content p {
    color: #647489;
    font-size: 12px;
}

.social {
    display: flex;
    gap: 18px;
}

.social a {
    color: #77879b;
    font-size: 12px;
}

.social a:hover {
    color: #55e6a5;
}


/* =========================
   RESPONSIVE
========================= */

@media (max-width: 900px) {

    nav {
        display: none;
    }

    .hero-content {
        grid-template-columns: 1fr;
        gap: 60px;
    }

    .terminal {
        transform: none;
    }

    .service-grid {
        grid-template-columns: 1fr 1fr;
    }

    .about-content {
        grid-template-columns: 1fr;
        gap: 50px;
    }

}


@media (max-width: 600px) {

    .hero {
        padding: 80px 0;
    }

    .hero h1 {
        font-size: 48px;
        letter-spacing: -2px;
    }

    .service-grid {
        grid-template-columns: 1fr;
    }

    .features {
        grid-template-columns: 1fr;
    }

    .stats {
        grid-template-columns: 1fr 1fr;
    }

    .cta-box {
        padding: 35px 25px;
        flex-direction: column;
        align-items: flex-start;
    }

    .footer-content {
        flex-direction: column;
        text-align: center;
    }

}
