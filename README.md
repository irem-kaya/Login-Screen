# Login Screen

Bu proje, kullanıcıların kimlik doğrulama işlemlerini gerçekleştirebilmeleri için geliştirilmiş bir giriş ekranı uygulamasıdır. Kullanıcılar, bu ekran aracılığıyla sisteme giriş yapabilirler.

## İçindekiler

- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Sınıf Detayları](#sınıf-detayları)
- [Katkıda Bulunma](#katkıda-bulunma)


## Özellikler

- Kullanıcı adı ve şifre ile giriş
- Hatalı giriş denemelerinde uyarı mesajı
- Basit ve kullanıcı dostu arayüz

## Kurulum

Projeyi yerel makinenize kurmak için aşağıdaki adımları izleyin:

1. Bu projeyi klonlayın:
    ```bash
    git clone https://github.com/irem-kaya/Login-Screen.git
    ```

2. Proje dizinine gidin:
    ```bash
    cd Login-Screen
    ```

3. Gerekli bağımlılıkları yükleyin:
    ```bash
    pip install -r requirements.txt
    ```

## Kullanım

Projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. Ana dosyayı çalıştırın:
    ```bash
    python main.py
    ```

2. Program başlatıldığında, kullanıcı adı ve şifrenizi girerek sisteme giriş yapabilirsiniz.

### Örnek Kullanım

```python
from login_screen import LoginScreen

# Giriş ekranı oluşturma
login = LoginScreen()

# Kullanıcı giriş denemesi
login.attempt_login('kullanici_adi', 'sifre')
