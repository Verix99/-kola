window.addEventListener("load", () => {
  const form = document.querySelector("#new-member-form");
  const input = document.querySelector("#new-task-input");
  const number = document.querySelector("#new-number-input");
  const list_el = document.querySelector("#tasks");
  const debt = document.querySelector("#new-debt-input");
  const vyber = document.querySelector("#clenove_vyber");
  let platby = 0;
  let count = 0;
  let dluh = 0;
  var celnove_list = new Array();

  //Funkce která počítá členy
  document.getElementById("new-task-submit").onclick = function () {
    count += 1;
    document.getElementById("clen_pocet").innerHTML = count;
  };

  //Funkce pro přidávání členů
  form.addEventListener("submit", (e) => {
    e.preventDefault();

    const clen = input.value;
    var num = number.value;

    if (!clen) {
      alert("Zapište člena!");
      count -= 1;
      document.getElementById("clen_pocet").innerHTML = count;
      return;
    }

    celnove_list[count] = clen;

    var options = "";

    for (var i = 0; i < celnove_list.length; i++) {
      options += '<option value="' + celnove_list[i] + '" />';
    }
    document.getElementById("anrede").innerHTML = options;

    const clen_el = document.createElement("div");
    clen_el.classList.add("task");

    const clen_content_el = document.createElement("div");
    clen_content_el.classList.add("content");

    clen_el.appendChild(clen_content_el);

    const clen_input_el = document.createElement("input");
    clen_input_el.classList.add("text");
    clen_input_el.setAttribute("id", "clen_jmeno" + [count]);
    clen_input_el.type = "text";
    clen_input_el.value = clen;
    clen_input_el.setAttribute("readonly", "readonly");

    let clen_number_el = document.createElement("input");
    clen_number_el.classList.add("number");
    clen_number_el.setAttribute("id", "clen_penize" + [count]);
    clen_number_el.type = "number";
    clen_number_el.value = 0;
    clen_number_el.setAttribute("readonly", "readonly");

    clen_content_el.appendChild(clen_input_el);
    clen_content_el.appendChild(clen_number_el);

    const clen_action_el = document.createElement("div");
    clen_action_el.classList.add("actions");

    const clen_check_el = document.createElement("input");
    clen_check_el.setAttribute("id", "checkbox_clen" + [count]);
    clen_check_el.classList.add("check");
    clen_check_el.type = "checkbox";

    const clen_delete_el = document.createElement("button");
    clen_delete_el.classList.add("delete");
    clen_delete_el.innerHTML = "Delete";

    clen_action_el.appendChild(clen_check_el);
    clen_action_el.appendChild(clen_delete_el);

    clen_el.appendChild(clen_action_el);

    list_el.appendChild(clen_el);

    input.value = "";
    number.value = "";

    //mazání členů
    clen_delete_el.addEventListener("click", () => {
      list_el.removeChild(clen_el);
      count -= 1;
      document.getElementById("clen_pocet").innerHTML = count;
    });
  });
  //Funkce která počítá transakce
  document.getElementById("new-debt-submit").onclick = function () {
    //počet plateb
    platby += 1;
    document.getElementById("platba").innerHTML = platby;

    //počítání dluhu
    let debt_castka = parseInt(debt.value);
    dluh = dluh + debt_castka;
    document.getElementById("dluh").innerHTML = dluh;

    const checkboxes = document.querySelectorAll('input[type="checkbox"]');
    function countChecked() {
      let count_1 = 0;
      checkboxes.forEach(function (checkbox) {
        if (checkbox.checked) {
          count_1++;
        }
      });

      return count_1;
    }
    const cislo_checkboxu = countChecked();
    let vysledna_castka_debt = debt_castka / cislo_checkboxu;
    console.log(`Počet zaškrtnutých checkboxů: ${countChecked()}`);
    let a = 0;
    let checking = document.querySelectorAll('input[type="checkbox"]').length;

    //projetí všech divu
    for (let i = 0; i <= checking; i++) {
      a++;
      var user = document.getElementById("clen_penize" + [a]).value;
      let user_parse = parseInt(user);
      let total_num = user_parse - vysledna_castka_debt;
      var check = document.getElementById("checkbox_clen" + [a]);
      var clen_jmeno = document.getElementById("clen_jmeno" + [a]).value;
      var clen_list = vyber.value;
      let castka_rozdeleni = debt_castka - vysledna_castka_debt;
      let castka_div = user_parse + castka_rozdeleni;
      let neskrtnuty_checkbox = user_parse + debt_castka;
      if (check.checked) {
        document.getElementById("clen_penize" + [a]).value =
          total_num.toFixed(2);
      }
      if (clen_jmeno == clen_list) {
        if (check.checked) {
          document.getElementById("clen_penize" + [a]).value =
            castka_div.toFixed(2);
          debt.value = "";
          vyber.value = "";
        } else {
          document.getElementById("clen_penize" + [a]).value =
            neskrtnuty_checkbox.toFixed(2);
          debt.value = "";
          vyber.value = "";
        }
      }
    }
  };
});
