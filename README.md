# eksicode-api-net-core


# Docker İle Ayağa Kaldırmak İçin

		1 ) Sisteminizde docker yüklü olduğundan emin olunuz.
		2 ) Reponun kök klasörüne geliniz.
		3 ) Local ortam için `docker-compose up --build`
			 Prod ortam için `docker-compose -f docker-compose.prod.yml up --build` komutlarını kullanarak sistemi ayağa kaldırabilirizsiniz.
		4 ) http://localhost/authentication/test gibi bir  mantık ile endpointlerinize erişebilirsiniz.