window.addEventListener("load", () => {
  const form = document.querySelector("#new-member-form");
  const input = document.querySelector("#new-task-input");
  const number = document.querySelector("#new-number-input");
  const list_el = document.querySelector("#tasks");
  const debt = document.querySelector("#new-debt-input");
  let platby = 0;
  let count = 0;

  //Funkce která počítá členy
  document.getElementById("new-task-submit").onclick = function () {
    count += 1;
    document.getElementById("demo").innerHTML = count;
  };

  //Funkce pro přidávání členů
  form.addEventListener("submit", (e) => {
    e.preventDefault();

    const task = input.value;
    var num = number.value;

    if (!task) {
      alert("Zapište člena!");
      count -= 1;
      document.getElementById("demo").innerHTML = count;
      return;
    }

    const task_el = document.createElement("div");
    task_el.classList.add("task");

    const task_content_el = document.createElement("div");
    task_content_el.classList.add("content");

    task_el.appendChild(task_content_el);

    const task_input_el = document.createElement("input");
    task_input_el.classList.add("text");
    task_input_el.setAttribute("id", "clen_jmeno");
    task_input_el.type = "text";
    task_input_el.value = task;
    task_input_el.setAttribute("readonly", "readonly");

    let task_number_el = document.createElement("input");
    task_number_el.classList.add("number");
    task_number_el.setAttribute("id", "clen_penize" + [count]);
    task_number_el.type = "number";
    task_number_el.value = num;
    task_number_el.setAttribute("readonly", "readonly");

    task_content_el.appendChild(task_input_el);
    task_content_el.appendChild(task_number_el);

    const task_action_el = document.createElement("div");
    task_action_el.classList.add("actions");

    const task_edit_el = document.createElement("input");
    task_edit_el.setAttribute("id", "checkbox_clen" + [count]);
    task_edit_el.classList.add("edit");
    task_edit_el.type = "checkbox";

    const task_delete_el = document.createElement("button");
    task_delete_el.classList.add("delete");
    task_delete_el.innerHTML = "Delete";

    task_action_el.appendChild(task_edit_el);
    task_action_el.appendChild(task_delete_el);

    task_el.appendChild(task_action_el);

    list_el.appendChild(task_el);

    input.value = "";
    number.value = "";

    //mazání členů
    task_delete_el.addEventListener("click", () => {
      list_el.removeChild(task_el);
      count -= 1;
      document.getElementById("demo").innerHTML = count;
    });
  });
  //Funkce která počítá transakce
  document.getElementById("new-debt-submit").onclick = function () {
    let dluh = 0;
    platby += 1;
    document.getElementById("platba").innerHTML = platby;
    const checkboxes = document.querySelectorAll('input[type="checkbox"]');
    const debt_castka = debt.value;
    debt_pocitani = parseInt(debt_castka);
    dluh += debt_pocitani;
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
    console.log(vysledna_castka_debt);
    let a = 0;
    let checking = document.querySelectorAll('input[type="checkbox"]').length;
    document.getElementById("dluh").innerHTML = dluh;
    for (let i = 0; i <= checking; i++) {
      a++;
      var user = document.getElementById("clen_penize" + [a]).value;
      let bobik = parseInt(user);
      let total = bobik + vysledna_castka_debt;
      var check = document.getElementById("checkbox_clen" + [a]);
      if (check.checked) {
        document.getElementById("clen_penize" + [a]).value = total;
        console.log(typeof debt_castka);
        debt.value = "";
      }
    }

    console.log(checking);
  };
});
