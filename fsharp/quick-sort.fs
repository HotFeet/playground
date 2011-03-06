(* following Haskell *)
let rec qsort1 l =
	match l with
	| [] -> []
	| x::xs ->
	let smaller = [for i in xs when i <= x -> i] in
	let larger = [for i in xs when i > x -> i] in
	(qsort smaller) @ [x] @ (qsort larger)

(* using filter *)
let rec qsort2 = function
	| [] -> []
	| (x:int) :: xs ->
		let smaller = List.filter ((<=) x) xs
		let larger  = List.filter ((>=) x) xs
		(qsort smaller) @ [x] @ (qsort larger)

(* using partition *)
let rec qsort3 = function
	| [] -> []
	| x::xs -> let smaller,larger = List.partition (fun y -> y<=x) xs
		qsort smaller @ [x] @ qsort larger