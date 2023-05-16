//načtení stránky
window.addEventListener("load", () => {
  //proměný
  const list_el = document.querySelector("#tasks");
  const debt = document.querySelector("#new-debt-input");
  const vyber = document.querySelector("#clenove_vyber");
  let platby = 0;
  let count = 0;
  let dluh = 0;
  const celnove_list = [];

  // Funkce po kliknutí na tlačítko "Přidat člena" v modálním okně
  document.getElementById("newbtn").onclick = function () {
    const clen = document.getElementById("new-task-inputik").value;

    // Kontrola vyplnění pole při přidávání člena
    if (!clen) {
      alert("Zapište člena!");
      return;
    }

    // Přidání počtu členů
    count += 1;
    document.getElementById("clen_pocet").innerHTML = count;

    // Přidání člena do seznamu
    celnove_list[count] = clen;

    // Vytvoření možností pro výběr členů
    let options = "";
    for (let i = 0; i < celnove_list.length; i++) {
      options += `<option value="${celnove_list[i]}"></option>`;
    }

    document.getElementById("member-list").innerHTML = options;

    // Vytvoření HTML elementů pro člena
    const clen_el = document.createElement("div");
    clen_el.classList.add("task");

    const clen_content_el = document.createElement("div");
    clen_content_el.classList.add("content");

    clen_el.appendChild(clen_content_el);

    const clen_input_el = document.createElement("input");
    clen_input_el.classList.add("text");
    clen_input_el.setAttribute("id", `clen_jmeno${count}`);
    clen_input_el.type = "text";
    clen_input_el.value = clen;
    clen_input_el.setAttribute("readonly", "readonly");

    const clen_number_el = document.createElement("input");
    clen_number_el.classList.add("number");
    clen_number_el.setAttribute("id", `clen_penize${count}`);
    clen_number_el.type = "number";
    clen_number_el.value = 0;
    clen_number_el.setAttribute("readonly", "readonly");

    clen_content_el.appendChild(clen_input_el);
    clen_content_el.appendChild(clen_number_el);

    const clen_action_el = document.createElement("div");
    clen_action_el.classList.add("actions");

    const clen_check_el = document.createElement("input");
    clen_check_el.setAttribute("id", `checkbox_clen${count}`);
    clen_check_el.classList.add("check");
    clen_check_el.type = "checkbox";

    const clen_delete_el = document.createElement("button");
    clen_delete_el.classList.add("delete");
    clen_delete_el.innerHTML = "Delete";

    clen_action_el.appendChild(clen_check_el);
    clen_action_el.appendChild(clen_delete_el);

    clen_el.appendChild(clen_action_el);

    list_el.appendChild(clen_el);

    // Vymazání hodnoty v poli pro přidání člena
    document.getElementById("new-task-inputik").value = "";

    // Funkce pro vymazání člena
    clen_delete_el.addEventListener("click", () => {
      list_el.removeChild(clen_el);
      count -= 1;
      document.getElementById("clen_pocet").innerHTML = count;
    });
  };

  //funkce která počítá transakce po kliknutí na tlačítko "Přidat platbu"
  document.getElementById("new-debt-submit").onclick = function () {
    platby += 1;
    document.getElementById("platba").innerHTML = platby;

    // Počítání dluhu
    const debt_castka = parseInt(debt.value);
    dluh += debt_castka;
    document.getElementById("dluh").innerHTML = dluh;

    //zkontrolování všech checkboxů, jestli jsou zaškrtnuté
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
    const vysledna_castka_debt = debt_castka / cislo_checkboxu;
    console.log(`Počet zaškrtnutých checkboxů: ${countChecked()}`);
    let a = 0;
    const checking = document.querySelectorAll('input[type="checkbox"]').length;

    //projetí všech divu a rozpočítání dluhu
    for (let i = 0; i <= checking; i++) {
      a++;
      const user = document.getElementById(`clen_penize${a}`).value;
      const user_parse = parseInt(user);
      const total_num = user_parse - vysledna_castka_debt;
      const check = document.getElementById(`checkbox_clen${a}`);
      const clen_jmeno = document.getElementById(`clen_jmeno${a}`).value;
      const clen_list = vyber.value;
      const castka_rozdeleni = debt_castka - vysledna_castka_debt;
      const castka_div = user_parse + castka_rozdeleni;
      const neskrtnuty_checkbox = user_parse + debt_castka;
      console.log(user);

      if (check.checked) {
        document.getElementById(`clen_penize${a}`).value = total_num.toFixed(2);
      }

      if (clen_jmeno == clen_list) {
        if (check.checked) {
          document.getElementById(`clen_penize${a}`).value =
            castka_div.toFixed(2);
          debt.value = "";
          vyber.value = "";
        } else {
          document.getElementById(`clen_penize${a}`).value =
            neskrtnuty_checkbox.toFixed(2);
          debt.value = "";
          vyber.value = "";
        }
      }

      check.checked = false;
    }
  };
});
