// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function fMasc(objeto, mascara) {
	obj = objeto
	masc = mascara
	setTimeout("fMascEx()", 1)
}
function fMascEx() {
	obj.value = masc(obj.value)
}
function mTel(tel) {
	tel = tel.replace(/\D/g, "")
	tel = tel.replace(/^(\d)/, "($1")
	tel = tel.replace(/(.{3})(\d)/, "$1)$2")
	if (tel.length == 9) {
		tel = tel.replace(/(.{1})$/, "-$1")
	} else if (tel.length == 10) {
		tel = tel.replace(/(.{2})$/, "-$1")
	} else if (tel.length == 11) {
		tel = tel.replace(/(.{3})$/, "-$1")
	} else if (tel.length == 12) {
		tel = tel.replace(/(.{4})$/, "-$1")
	} else if (tel.length > 12) {
		tel = tel.replace(/(.{4})$/, "-$1")
	}
	return tel;
}
function mCNPJ(cnpj) {
	cnpj = cnpj.replace(/\D/g, "")
	cnpj = cnpj.replace(/^(\d{2})(\d)/, "$1.$2")
	cnpj = cnpj.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3")
	cnpj = cnpj.replace(/\.(\d{3})(\d)/, ".$1/$2")
	cnpj = cnpj.replace(/(\d{4})(\d)/, "$1-$2")
	return cnpj
}
function mCPF(cpf) {
	cpf = cpf.replace(/\D/g, "")
	cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
	cpf = cpf.replace(/(\d{3})(\d)/, "$1.$2")
	cpf = cpf.replace(/(\d{3})(\d{1,2})$/, "$1-$2")
	return cpf
}
function mCEP(cep) {
	cep = cep.replace(/\D/g, "")
	cep = cep.replace(/^(\d{2})(\d)/, "$1.$2")
	cep = cep.replace(/\.(\d{3})(\d)/, ".$1-$2")
	return cep
}
function mNum(num) {
	num = num.replace(/\D/g, "")
	return num
}

function chooseDocumentMask(text) {
	if (text.length <= 11) {
		text = text.replace(/\D/g, "")
		text = text.replace(/(\d{3})(\d)/, "$1.$2")
		text = text.replace(/(\d{3})(\d)/, "$1.$2")
		text = text.replace(/(\d{3})(\d{1,2})$/, "$1-$2")
		return text
	} else {
		text = text.replace(/\D/g, "")
		text = text.replace(/^(\d{2})(\d)/, "$1.$2")
		text = text.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3")
		text = text.replace(/\.(\d{3})(\d)/, ".$1/$2")
		text = text.replace(/(\d{4})(\d)/, "$1-$2")
		return text
	}
	return text
}

function mascaraDeTelefone(v) {

	if (v <= 9) {
		v = v.replace(/\D/g, "");
		v = v.replace(/^(\d{2})(\d)/g, "($1) $2");
		v = v.replace(/(\d)(\d{5})$/, "$1-$2");
		return v;
	} else {
		v = v.replace(/\D/g, "");
		v = v.replace(/^(\d{2})(\d)/g, "($1) $2");
		v = v.replace(/(\d)(\d{4})$/, "$1-$2");
		return v;
	}

	return v
}