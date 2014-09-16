<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>CV</title>
	<link rel="stylesheet" href="style.css">
</head>
<body>
	<?php if ( isset( $_POST['submit'] ) ) : ?>
	<?php
		$firstName = $_POST['fn'];
		$lastName = $_POST['ln'];

		if ( isset( $_FILES['image'] ) ) {
		    $aExtraInfo = getimagesize( $_FILES['image']['tmp_name'] );
		    $sImage = 'data:' . $aExtraInfo['mime'] . ';base64,'
		    			. base64_encode( file_get_contents( $_FILES['image']['tmp_name'] ) );
		}

		$email = $_POST['email'];
		$phone = $_POST['phone'];
		$gender = $_POST['gender'];
		$bday = $_POST['bday'];
		$nation = $_POST['nation'];

		$company = $_POST['company'];
		$workedFrom = $_POST['workedFrom'];
		$workedTo = $_POST['workedTo'];

		$prLang = $_POST['pr-lang'];
		$progLvl = $_POST['lvl'];

		$spLang = $_POST['lang'];
		$comprehension = $_POST['comprehension'];
		$reading = $_POST['reading'];
		$writing = $_POST['writing'];
		if( isset( $_POST['license'] ) ) {
			$license = implode( ', ', $_POST['license'] );
		}

	?>
	<h2>CV</h2>
	<img src="<?php echo $sImage; ?>" alt="Your Image" />
	<table border="1">
		<thead>
			<tr>
				<th colspan="2">Personal Information</th>
			</tr>
			<tbody>
				<tr>
					<td>First name</td>
					<td><?php echo $firstName; ?></td>
				</tr>
				<tr>
					<td>Last name</td>
					<td><?php echo $lastName; ?></td>
				</tr>
				<tr>
					<td>Email</td>
					<td><?php echo $email; ?></td>
				</tr>
				<tr>
					<td>Phone number</td>
					<td><?php echo $phone; ?></td>
				</tr>
				<tr>
					<td>Gender</td>
					<td><?php echo $gender; ?></td>
				</tr>
				<tr>
					<td>Birth date</td>
					<td><?php echo $bday; ?></td>
				</tr>
				<tr>
					<td>Nationality</td>
					<td><?php echo $nation; ?></td>
				</tr>
			</tbody>
		</thead>
	</table>
	<table border="1">
		<thead>
			<tr>
				<th colspan="2">Last Work Position</th>
			</tr>
			<tbody>
				<tr>
					<td>Company name</td>
					<td><?php echo $company; ?></td>
				</tr>
				<tr>
					<td>From</td>
					<td><?php echo $workedFrom; ?></td>
				</tr>
				<tr>
					<td>To</td>
					<td><?php echo $workedTo; ?></td>
				</tr>
			</tbody>
		</thead>
	</table>
	<table border="1">
		<thead>
			<tr>
				<th colspan="2">Computer Skills</th>
			</tr>
			<tbody>
				<tr>
					<td>Programming languages</td>
					<td>
						<table border="1">
							<thead>
								<tr>
									<th>Language</th>
									<th>Skill level</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td><?php echo $prLang; ?></td>
									<td><?php echo $progLvl; ?></td>
								</tr>
							</tbody>
						</table>
					</td>
				</tr>
			</tbody>
		</thead>
	</table>
	<table border="1">
		<thead>
			<tr>
				<th colspan="2">Other Skills</th>
			</tr>
			<tbody>
				<tr>
					<td>Languages</td>
					<td>
						<table border="1">
							<thead>
								<tr>
									<th>Language</th>
									<th>Comprehension</th>
									<th>Reading</th>
									<th>Writing</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td><?php echo $spLang; ?></td>
									<td><?php echo $comprehension; ?></td>
									<td><?php echo $reading; ?></td>
									<td><?php echo $writing; ?></td>
								</tr>
							</tbody>
						</table>
					</td>
				</tr>
				<tr>
					<td>Driver's license</td>
					<td><?php echo $license; ?></td>
				</tr>
			</tbody>
		</thead>
	</table>
	<?php endif; ?>
</body>
</html>
